using System.Buffers;
using System.Collections.Frozen;
using System.Runtime.CompilerServices;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
[SimpleJob(iterationCount: 25)]
public class FrozenHashTableBenchmark : BenchmarkBase
{
    [ParamsSource(nameof(Generate_10_to_100000))]
    public int DictionarySize { get; set; }
    public record MyClass(int Value);
    private MyClass[] _collection = default!;

    [GlobalSetup]
    public void Initialize()
    {
        _collection = new MyClass[DictionarySize];
        for (int i = 0; i < DictionarySize; i++)
        {
            _collection[i] = new(i);
        }

        var frozenDictionary = _collection.ToFrozenDictionary(x => x, x => x.Value * x.Value);

        if (frozenDictionary.GetType().Name != "DefaultFrozenDictionary`2")
        {
            throw new Exception($"Invalid FrozenDictionary type: {frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public Dictionary<MyClass, int> Dictionary() =>
        _collection.ToDictionary(x => x, x => x.Value * x.Value);

    [Benchmark]
    public FrozenDictionary<MyClass, int> FrozenDictionary() =>
        _collection.ToFrozenDictionary(x => x, x => x.Value * x.Value);
}

/// <summary>Provides the core hash table for use in frozen collections.</summary>
/// <remarks>
/// This hash table doesn't track any of the collection state. It merely keeps track
/// of hash codes and of mapping these hash codes to spans of entries within the collection.
/// </remarks>
public readonly struct FrozenHashTable
{
    public readonly Bucket[] _buckets;
    public readonly ulong _fastModMultiplier;
    public int Count => HashCodes.Length;
    public int[] HashCodes { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendFormat("FastModeMultuplier: {0}", _fastModMultiplier);
        sb.AppendLine();
        sb.AppendFormat("HashCodes ({0}): {1}", Count, string.Join(" ", HashCodes));
        sb.AppendLine();
        sb.AppendFormat("Buckets: {0}", string.Join(", ", _buckets.Select((x, i) => $"\n{i}: {x.StartIndex} - {x.EndIndex}")));
        return sb.ToString();
    }

    /// <summary>Initializes the hashtable with the computed hashcodes and bucket information.</summary>
    /// <param name="hashCodes">The array of hashcodes grouped into contiguous regions by bucket. Each bucket is one and only one region of the array.</param>
    /// <param name="buckets">
    /// The array of buckets, indexed by hashCodes % buckets.Length, where each bucket is
    /// the start/end index into <paramref name="hashCodes"/> for all items in that bucket.
    /// </param>
    /// <param name="fastModMultiplier">The multiplier to use as part of a FastMod method call.</param>
    private FrozenHashTable(int[] hashCodes, Bucket[] buckets, ulong fastModMultiplier)
    {
        HashCodes = hashCodes;
        _buckets = buckets;
        _fastModMultiplier = fastModMultiplier;
    }

    /// <summary>Initializes a frozen hash table.</summary>
    /// <param name="hashCodes">Pre-calculated hash codes. When the method finishes, it assigns each value to destination index.</param>
    /// <param name="hashCodesAreUnique">True when the input hash codes are already unique (provided from a dictionary of integers for example).</param>
    /// <remarks>
    /// It will then determine the optimal number of hash buckets to allocate and will populate the
    /// bucket table. The caller is responsible to consume the values written to <paramref name="hashCodes"/> and update the destination (if desired).
    /// <see cref="FindMatchingEntries(int, out int, out int)"/> then uses this index to reference individual entries by indexing into <see cref="HashCodes"/>.
    /// </remarks>
    /// <returns>A frozen hash table.</returns>
    public static FrozenHashTable Create(Span<int> hashCodes, bool hashCodesAreUnique = false)
    {
        // Determine how many buckets to use.  This might be fewer than the number of entries
        // if any entries have identical hashcodes (not just different hashcodes that might
        // map to the same bucket).
        int numBuckets = CalcNumBuckets(hashCodes, hashCodesAreUnique);
        ulong fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)numBuckets);
        Console.WriteLine($"numBuckets: {numBuckets}, fastModMultiplier: {fastModMultiplier}");

        // Create two spans:
        // - bucketStarts: initially filled with all -1s, the ith element stores the index
        //   into hashCodes of the head element of that bucket's chain.
        // - nexts: the ith element stores the index of the next item in the chain.
        int[] arrayPoolBuckets = ArrayPool<int>.Shared.Rent(numBuckets + hashCodes.Length);
        Span<int> bucketStarts = arrayPoolBuckets.AsSpan(0, numBuckets);
        Span<int> nexts = arrayPoolBuckets.AsSpan(numBuckets, hashCodes.Length);
        bucketStarts.Fill(-1);

        // Populate the bucket entries and starts.  For each hash code, compute its bucket,
        // and store at the bucket entry corresponding to the hashcode item the entry for that
        // item, which includes a copy of the hash code and the current bucket start, which
        // is then replaced by this entry as it's pushed into the bucket list.
        for (int index = 0; index < hashCodes.Length; index++)
        {
            int hashCode = hashCodes[index];
            int bucketNum = (int)HashHelpers.FastMod((uint)hashCode, (uint)bucketStarts.Length, fastModMultiplier);

            ref int bucketStart = ref bucketStarts[bucketNum];
            nexts[index] = bucketStart;
            bucketStart = index;
        }

        // Write out the hashcodes and buckets arrays to be used by the FrozenHashtable instance.
        // We iterate through each bucket start, and from each, each item in that chain, writing
        // out all of the items in each chain next to each other in the hashcodes list (and
        // calling the setter to allow the consumer to reorder its entries appropriately).
        // Along the way we could how many items are in each chain, and use that along with
        // the starting index to write out the bucket information for indexing into hashcodes.
        var hashtableHashcodes = new int[hashCodes.Length];
        var hashtableBuckets = new Bucket[bucketStarts.Length];
        int count = 0;
        for (int bucketNum = 0; bucketNum < hashtableBuckets.Length; bucketNum++)
        {
            int bucketStart = bucketStarts[bucketNum];
            if (bucketStart < 0)
            {
                continue;
            }

            int bucketCount = 0;
            int index = bucketStart;
            bucketStart = count;
            while (index >= 0)
            {
                ref int hashCode = ref hashCodes[index];
                hashtableHashcodes[count] = hashCode;
                // we have used the hash code for the last time, now we re-use the buffer to store destination index
                hashCode = count;
                count++;
                bucketCount++;

                index = nexts[index];
            }

            hashtableBuckets[bucketNum] = new Bucket(bucketStart, bucketCount);
        }

        ArrayPool<int>.Shared.Return(arrayPoolBuckets);

        return new FrozenHashTable(hashtableHashcodes, hashtableBuckets, fastModMultiplier);
    }

    /// <summary>
    /// Given a hash code, return the first index and last index for the associated matching entries.
    /// </summary>
    /// <param name="hashCode">The hash code to probe for.</param>
    /// <param name="startIndex">A variable that receives the index of the first matching entry.</param>
    /// <param name="endIndex">A variable that receives the index of the last matching entry plus 1.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void FindMatchingEntries(int hashCode, out int startIndex, out int endIndex)
    {
        Bucket[] buckets = _buckets;
        Console.WriteLine("hash: {0}, buckets.Length: {1}, _fastModMultiplier: {2}, result: {3}", 
            hashCode, 
            buckets.Length, 
            _fastModMultiplier, 
            HashHelpers.FastMod((uint)hashCode, (uint)buckets.Length, _fastModMultiplier));
        ref Bucket b = ref buckets[HashHelpers.FastMod((uint)hashCode, (uint)buckets.Length, _fastModMultiplier)];
        startIndex = b.StartIndex;
        endIndex = b.EndIndex;
    }

    /// <summary>
    /// Given a span of hash codes, figure out the best number of hash buckets to use.
    /// </summary>
    /// <remarks>
    /// This tries to select a prime number of buckets. Rather than iterating through all possible bucket
    /// sizes, starting at the exact number of hash codes and incrementing the bucket count by 1 per trial,
    /// this is a trade-off between speed of determining a good number of buckets and maximal density.
    /// </remarks>
    private static int CalcNumBuckets(ReadOnlySpan<int> hashCodes, bool hashCodesAreUnique)
    {
        const double AcceptableCollisionRate = 0.05;  // What is a satisfactory rate of hash collisions?
        const int LargeInputSizeThreshold = 1000;     // What is the limit for an input to be considered "small"?
        const int MaxSmallBucketTableMultiplier = 16; // How large a bucket table should be allowed for small inputs?
        const int MaxLargeBucketTableMultiplier = 3;  // How large a bucket table should be allowed for large inputs?

        // Filter out duplicate codes, since no increase in buckets will avoid collisions from duplicate input hash codes.
        HashSet<int>? codes = null;
        int uniqueCodesCount = hashCodes.Length;
        if (!hashCodesAreUnique)
        {
            codes = [.. hashCodes];
            uniqueCodesCount = codes.Count;
        }

        // Based on our observations, in more than 99.5% of cases the number of buckets that meets our criteria is
        // at least twice as big as the number of unique hash codes.
        int minNumBuckets = uniqueCodesCount * 2;

        // In our precomputed primes table, find the index of the smallest prime that's at least as large as our number of
        // hash codes. If there are more codes than in our precomputed primes table, which accommodates millions of values,
        // give up and just use the next prime.
        ReadOnlySpan<int> primes = HashHelpers.Primes;
        int minPrimeIndexInclusive = 0;
        while ((uint)minPrimeIndexInclusive < (uint)primes.Length && minNumBuckets > primes[minPrimeIndexInclusive])
        {
            minPrimeIndexInclusive++;
        }

        if (minPrimeIndexInclusive >= primes.Length)
        {
            return HashHelpers.GetPrime(uniqueCodesCount);
        }

        // Determine the largest number of buckets we're willing to use, based on a multiple of the number of inputs.
        // For smaller inputs, we allow for a larger multiplier.
        int maxNumBuckets =
            uniqueCodesCount *
            (uniqueCodesCount >= LargeInputSizeThreshold ? MaxLargeBucketTableMultiplier : MaxSmallBucketTableMultiplier);

        // Find the index of the smallest prime that accommodates our max buckets.
        int maxPrimeIndexExclusive = minPrimeIndexInclusive;
        while ((uint)maxPrimeIndexExclusive < (uint)primes.Length && maxNumBuckets > primes[maxPrimeIndexExclusive])
        {
            maxPrimeIndexExclusive++;
        }

        if (maxPrimeIndexExclusive < primes.Length)
        {
            maxNumBuckets = primes[maxPrimeIndexExclusive - 1];
        }

        Console.WriteLine($"minNumBuckets: {minNumBuckets}, maxNumBuckets: {maxNumBuckets}");

        const int BitsPerInt32 = 32;
        int[] seenBuckets = ArrayPool<int>.Shared.Rent((maxNumBuckets / BitsPerInt32) + 1);

        int bestNumBuckets = maxNumBuckets;
        int bestNumCollisions = uniqueCodesCount;
        int numBuckets = 0, numCollisions = 0;

        // Iterate through each available prime between the min and max discovered. For each, compute
        // the collision ratio.
        for (int primeIndex = minPrimeIndexInclusive; primeIndex < maxPrimeIndexExclusive; primeIndex++)
        {
            // Get the number of buckets to try, and clear our seen bucket bitmap.
            numBuckets = primes[primeIndex];
            Array.Clear(seenBuckets, 0, Math.Min(numBuckets, seenBuckets.Length));

            // Determine the bucket for each hash code and mark it as seen. If it was already seen,
            // track it as a collision.
            numCollisions = 0;

            if (codes is not null && uniqueCodesCount != hashCodes.Length)
            {
                foreach (int code in codes)
                {
                    if (!IsBucketFirstVisit(code))
                    {
                        break;
                    }
                }
            }
            else
            {
                // All of the hash codes in hashCodes are unique. In such scenario, it's faster to iterate over a span.
                foreach (int code in hashCodes)
                {
                    if (!IsBucketFirstVisit(code))
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"numBuckets: {numBuckets}, numCollisions: {numCollisions}, bestNumCollisions: {bestNumCollisions}, collisionRate: {numCollisions / (double)uniqueCodesCount}");

            // If this evaluation resulted in fewer collisions, use it as the best instead.
            // And if it's below our collision threshold, we're done.
            if (numCollisions < bestNumCollisions)
            {
                bestNumBuckets = numBuckets;

                if (numCollisions / (double)uniqueCodesCount <= AcceptableCollisionRate)
                {
                    break;
                }

                bestNumCollisions = numCollisions;
            }
        }

        ArrayPool<int>.Shared.Return(seenBuckets);

        return bestNumBuckets;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool IsBucketFirstVisit(int code)
        {
            uint bucketNum = (uint)code % (uint)numBuckets;
            Console.WriteLine($"\tcode: {code}, code: {(uint)code}, numBuckets, {numBuckets}, bucketNum: {bucketNum}, bucket Ind: {bucketNum / BitsPerInt32}, collisions: {numCollisions}");
            
            if ((seenBuckets[bucketNum / BitsPerInt32] & (1 << (int)bucketNum)) != 0)
            {
                numCollisions++;
                if (numCollisions >= bestNumCollisions)
                {
                    Console.WriteLine("\thit the previously known best number of collisions");
                    // If we've already hit the previously known best number of collisions,
                    // there's no point in continuing as worst case we'd just use that.
                    return false;
                }
            }
            else
            {
                seenBuckets[bucketNum / BitsPerInt32] |= 1 << (int)bucketNum;
            }

            return true;
        }
    }

    public readonly record struct Bucket
    {
        public readonly int StartIndex;
        public readonly int EndIndex;

        public Bucket(int startIndex, int count)
        {
            StartIndex = startIndex;
            EndIndex = startIndex + count - 1;
        }
    }
}

internal static partial class HashHelpers
{
    public const uint HashCollisionThreshold = 100;

    // This is the maximum prime smaller than Array.MaxLength.
    public const int MaxPrimeArrayLength = 0x7FFFFFC3;

    public const int HashPrime = 101;

    // Table of prime numbers to use as hash table sizes.
    // A typical resize algorithm would pick the smallest prime number in this array
    // that is larger than twice the previous capacity.
    // Suppose our Hashtable currently has capacity x and enough elements are added
    // such that a resize needs to occur. Resizing first computes 2x then finds the
    // first prime in the table greater than 2x, i.e. if primes are ordered
    // p_1, p_2, ..., p_i, ..., it finds p_n such that p_n-1 < 2x < p_n.
    // Doubling is important for preserving the asymptotic complexity of the
    // hashtable operations such as add.  Having a prime guarantees that double
    // hashing does not lead to infinite loops.  IE, your hash function will be
    // h1(key) + i*h2(key), 0 <= i < size.  h2 and the size must be relatively prime.
    // We prefer the low computation costs of higher prime numbers over the increased
    // memory allocation of a fixed prime number i.e. when right sizing a HashSet.
    internal static ReadOnlySpan<int> Primes =>
    [
        3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919,
            1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591,
            17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437,
            187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263,
            1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369
    ];

    public static bool IsPrime(int candidate)
    {
        if ((candidate & 1) != 0)
        {
            int limit = (int)Math.Sqrt(candidate);
            for (int divisor = 3; divisor <= limit; divisor += 2)
            {
                if ((candidate % divisor) == 0)
                    return false;
            }
            return true;
        }
        return candidate == 2;
    }

    public static int GetPrime(int min)
    {
        if (min < 0)
            throw new ArgumentException("", nameof(min));

        foreach (int prime in Primes)
        {
            if (prime >= min)
                return prime;
        }

        // Outside of our predefined table. Compute the hard way.
        for (int i = (min | 1); i < int.MaxValue; i += 2)
        {
            if (IsPrime(i) && ((i - 1) % HashPrime != 0))
                return i;
        }
        return min;
    }

    // Returns size of hashtable to grow to.
    public static int ExpandPrime(int oldSize)
    {
        int newSize = 2 * oldSize;

        // Allow the hashtables to grow to maximum possible size (~2G elements) before encountering capacity overflow.
        // Note that this check works even when _items.Length overflowed thanks to the (uint) cast
        if ((uint)newSize > MaxPrimeArrayLength && MaxPrimeArrayLength > oldSize)
        {
            return MaxPrimeArrayLength;
        }

        return GetPrime(newSize);
    }

    /// <summary>Returns approximate reciprocal of the divisor: ceil(2**64 / divisor).</summary>
    /// <remarks>This should only be used on 64-bit.</remarks>
    public static ulong GetFastModMultiplier(uint divisor) =>
        ulong.MaxValue / divisor + 1;

    /// <summary>Performs a mod operation using the multiplier pre-computed with <see cref="GetFastModMultiplier"/>.</summary>
    /// <remarks>This should only be used on 64-bit.</remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint FastMod(uint value, uint divisor, ulong multiplier)
    {
        // We use modified Daniel Lemire's fastmod algorithm (https://github.com/dotnet/runtime/pull/406),
        // which allows to avoid the long multiplication if the divisor is less than 2**31.

        // This is equivalent of (uint)Math.BigMul(multiplier * value, divisor, out _). This version
        // is faster than BigMul currently because we only need the high bits.
        uint highbits = (uint)(((((multiplier * value) >> 32) + 1) * divisor) >> 32);

        return highbits;
    }
}
