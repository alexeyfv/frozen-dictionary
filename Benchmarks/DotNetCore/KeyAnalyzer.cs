using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;

#if !NET8_0_OR_GREATER
using System.Runtime.CompilerServices;

#endif

namespace Benchmark.Benchmarks.DotNetCore;

internal static class KeyAnalyzer
{
    /// <summary>
    /// Look for well-known patterns we can optimize for in a set of dictionary or set keys.
    /// </summary>
    /// <remarks>
    /// The idea here is to find the shortest substring slice across all the input strings which yields a set of
    /// strings which are maximally unique. The optimal slice is then applied to incoming strings being hashed to
    /// perform dictionary/set lookups. Keeping the slices as small as possible minimizes the number of characters
    /// involved in hashing, speeding up the whole process.
    ///
    /// What we do here is pretty simple. We loop over the input strings, looking for the shortest slice with a good
    /// enough uniqueness factor. We look at all the strings both left-justified and right-justified as this maximizes
    /// the opportunities to find unique slices, especially in the case of many strings with the same prefix or suffix.
    ///
    /// In whatever slice we end up with, if all the characters involved in the slice are ASCII and we're doing case-insensitive
    /// operations, then we can select an ASCII-specific case-insensitive comparer which yields faster overall performance.
    /// </remarks>
    public static AnalysisResults Analyze(
        ReadOnlySpan<string> uniqueStrings, bool ignoreCase, int minLength, int maxLength)
    {
        Debug.Assert(!uniqueStrings.IsEmpty);
        bool allUniqueStringsAreConfirmedAscii = ignoreCase && AreAllAscii(uniqueStrings);

        // Try to pick a substring comparer. If we can't find a good substring comparer, fallback to a full string comparer.
        AnalysisResults results;
        if (minLength == 0 || !TryUseSubstring(uniqueStrings, allUniqueStringsAreConfirmedAscii, ignoreCase, minLength, maxLength, out results))
        {
            results = CreateAnalysisResults(uniqueStrings, allUniqueStringsAreConfirmedAscii, ignoreCase, minLength, maxLength, 0, 0, static (s, _, _) => s.AsSpan());
        }

        return results;
    }

    /// <summary>Try to find the minimal unique substring index/length to use for comparisons.</summary>
    private static bool TryUseSubstring(ReadOnlySpan<string> uniqueStrings, bool allUniqueStringsAreConfirmedAscii, bool ignoreCase, int minLength, int maxLength, out AnalysisResults results)
    {
        const int MaxSubstringLengthLimit = 8; // arbitrary small-ish limit... it's not worth the increase in algorithmic complexity to analyze longer substrings

        // Sufficient uniqueness factor of 95% is good enough.
        // Instead of ensuring that 95% of data is good, we stop when we know that at least 5% is bad.
        int acceptableNonUniqueCount = uniqueStrings.Length / 20;

        // If we're case-sensitive, we can just use a case-sensitive substring comparer, which is cheap.
        // For case-insensitive / ignoreCase, we don't know which portion of the input strings we're going to care about.
        // However, if all of the strings are entirely ASCII, we know that no portion of any will be non-ASCII and thus can
        // use a comparer that only knows how to do ASCII-based ordinal casing, which is cheaper than full Unicode casing,
        // in particular for GetHashCode.
        SubstringComparer comparer =
            !ignoreCase ? new JustifiedSubstringComparer() :
            allUniqueStringsAreConfirmedAscii ? new JustifiedCaseInsensitiveAsciiSubstringComparer() :
            new JustifiedCaseInsensitiveSubstringComparer();

        HashSet<string> set = new HashSet<string>(
#if NET
            uniqueStrings.Length,
#endif
            comparer);

        // For each substring length...preferring the shortest length that provides
        // enough uniqueness
        int maxSubstringLength = Math.Min(minLength, MaxSubstringLengthLimit);
        for (int count = 1; count <= maxSubstringLength; count++)
        {
            comparer.IsLeft = true;
            comparer.Count = count;

            // For each index from, get a uniqueness factor for the left-justified substrings.
            // If any is above our threshold, we're done.
            for (int index = 0; index <= minLength - count; index++)
            {
                comparer.Index = index;

                if (HasSufficientUniquenessFactor(set, uniqueStrings, acceptableNonUniqueCount))
                {
                    results = CreateAnalysisResults(
                        uniqueStrings, allUniqueStringsAreConfirmedAscii, ignoreCase, minLength, maxLength, index, count,
                        static (string s, int index, int count) => s.AsSpan(index, count));
                    return true;
                }
            }

            // There were no left-justified substrings of this length available.
            // If all of the strings are of the same length, then just checking left-justification is sufficient.
            // But if any strings are of different lengths, then we'll get different alignments for left- vs
            // right-justified substrings, and so we also check right-justification.
            if (minLength != maxLength)
            {
                // toggle the direction and re-use the comparer and hashset (HasSufficientUniquenessFactor clears it)
                comparer.IsLeft = false;

                // For each index, get a uniqueness factor for the right-justified substrings.
                // If any is above our threshold, we're done.
                for (int index = 0; index <= minLength - count; index++)
                {
                    comparer.Index = -index - count;

                    if (HasSufficientUniquenessFactor(set, uniqueStrings, acceptableNonUniqueCount))
                    {
                        results = CreateAnalysisResults(
                            uniqueStrings, allUniqueStringsAreConfirmedAscii, ignoreCase, minLength, maxLength, comparer.Index, count,
                            static (string s, int index, int count) => s.AsSpan(s.Length + index, count));
                        return true;
                    }
                }
            }
        }

        // Could not find a substring index/length that was good enough.
        results = default;
        return false;
    }

    private static AnalysisResults CreateAnalysisResults(
        ReadOnlySpan<string> uniqueStrings, bool allUniqueStringsAreConfirmedAscii, bool ignoreCase, int minLength, int maxLength, int index, int count, GetSpan getHashString)
    {
        // Start off by assuming all strings are ASCII
        bool allAsciiIfIgnoreCase = true;

        // If we're case-sensitive, it doesn't matter if the strings are ASCII or not.
        // But if we're case-insensitive, we can switch to a faster comparer if all the
        // substrings are ASCII, so we check each.
        if (ignoreCase)
        {
            // Further, if the ASCII keys (in their entirety) don't contain any letters,
            // then we can actually perform the comparison as case-sensitive even if
            // case-insensitive was requested, as there's nothing that would compare
            // equally to the key other than the key itself.
            bool canSwitchIgnoreCaseHashToCaseSensitive = true;

            foreach (string uniqueString in uniqueStrings)
            {
                // Get a span representing the slice of the uniqueString which will be hashed.
                // If the slice isn't ASCII, bail out to return the results.
                if (!allUniqueStringsAreConfirmedAscii &&
                    !IsAllAscii(getHashString(uniqueString, index, count)))
                {
                    allAsciiIfIgnoreCase = false;
                    canSwitchIgnoreCaseHashToCaseSensitive = false;
                    break;
                }

                // The hash string is ASCII only.  We disable the switch to
                // case sensitive if by examining the entire uniqueString we
                // find that it is not ASCII, or that it contains ASCII letters.
                if (canSwitchIgnoreCaseHashToCaseSensitive)
                {
                    // If count is 0 then uniqueString equals hashString,
                    // and as we have just checked that IsAllAscii(hashString) is true
                    // then we know IsAllAscii(uniqueString) must be true,
                    // so we can skip the check.
                    if ((count > 0 && !allUniqueStringsAreConfirmedAscii && !IsAllAscii(uniqueString.AsSpan())) ||
                        ContainsAnyAsciiLetters(uniqueString.AsSpan()))
                    {
                        canSwitchIgnoreCaseHashToCaseSensitive = false;
                        if (allUniqueStringsAreConfirmedAscii)
                        {
                            break;
                        }
                    }
                }
            }

            // If we can switch to case-sensitive, do so.
            if (canSwitchIgnoreCaseHashToCaseSensitive)
            {
                ignoreCase = false;
            }
        }

        // Return the analysis results.
        return new AnalysisResults(ignoreCase, allAsciiIfIgnoreCase, index, count, minLength, maxLength);
    }

    private delegate ReadOnlySpan<char> GetSpan(string s, int index, int count);

    private static bool AreAllAscii(ReadOnlySpan<string> strings)
    {
        foreach (string s in strings)
        {
            if (!IsAllAscii(s.AsSpan()))
            {
                return false;
            }
        }

        return true;
    }

    internal static unsafe bool IsAllAscii(ReadOnlySpan<char> s)
    {
#if NET8_0_OR_GREATER
        return System.Text.Ascii.IsValid(s);
#else
            fixed (char* src = s)
            {
                uint* ptrUInt32 = (uint*)src;
                int length = s.Length;

                while (length >= 4)
                {
                    if (!AllCharsInUInt32AreAscii(ptrUInt32[0] | ptrUInt32[1]))
                    {
                        return false;
                    }

                    ptrUInt32 += 2;
                    length -= 4;
                }

                char* ptrChar = (char*)ptrUInt32;
                while (length-- > 0)
                {
                    char ch = *ptrChar++;
                    if (ch >= 0x80)
                    {
                        return false;
                    }
                }
            }

            return true;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static bool AllCharsInUInt32AreAscii(uint value) => (value & ~0x007F_007Fu) == 0;
#endif
    }

#if NET8_0_OR_GREATER
    private static readonly SearchValues<char> s_asciiLetters = SearchValues.Create("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
#endif
    internal static bool ContainsAnyAsciiLetters(ReadOnlySpan<char> s)
    {
        Debug.Assert(IsAllAscii(s));

#if NET8_0_OR_GREATER
        return s.ContainsAny(s_asciiLetters);
#else
            foreach (char c in s)
            {
                Debug.Assert(c <= 0x7f);
                if ((uint)((c | 0x20) - 'a') <= (uint)('z' - 'a'))
                {
                    return true;
                }
            }
            return false;
#endif
    }

    internal static bool HasSufficientUniquenessFactor(HashSet<string> set, ReadOnlySpan<string> uniqueStrings, int acceptableNonUniqueCount)
    {
        set.Clear();

        foreach (string s in uniqueStrings)
        {
            if (!set.Add(s) && --acceptableNonUniqueCount < 0)
            {
                return false;
            }
        }

        return true;
    }

    internal readonly struct AnalysisResults
    {
        public AnalysisResults(bool ignoreCase, bool allAsciiIfIgnoreCase, int hashIndex, int hashCount, int minLength, int maxLength)
        {
            IgnoreCase = ignoreCase;
            AllAsciiIfIgnoreCase = allAsciiIfIgnoreCase;
            HashIndex = hashIndex;
            HashCount = hashCount;
            MinimumLength = minLength;
            MaximumLengthDiff = maxLength - minLength;
        }

        public bool IgnoreCase { get; }
        public bool AllAsciiIfIgnoreCase { get; }
        public int HashIndex { get; }
        public int HashCount { get; }
        public int MinimumLength { get; }
        public int MaximumLengthDiff { get; }

        public bool SubstringHashing => HashCount != 0;
        public bool RightJustifiedSubstring => HashIndex < 0;
    }

    private abstract class SubstringComparer : IEqualityComparer<string>
    {
        public int Index;
        public int Count;
        public bool IsLeft;
        public abstract bool Equals(string? x, string? y);
        public abstract int GetHashCode(string s);
    }

    private sealed class JustifiedSubstringComparer : SubstringComparer
    {
        public override bool Equals(string? x, string? y) => x.AsSpan(IsLeft ? Index : (x!.Length + Index), Count).SequenceEqual(y.AsSpan(IsLeft ? Index : (y!.Length + Index), Count));
        public override int GetHashCode(string s) => Hashing.GetHashCodeOrdinal(s.AsSpan(IsLeft ? Index : (s.Length + Index), Count));
    }

    private sealed class JustifiedCaseInsensitiveSubstringComparer : SubstringComparer
    {
        public override bool Equals(string? x, string? y) => x.AsSpan(IsLeft ? Index : (x!.Length + Index), Count).Equals(y.AsSpan(IsLeft ? Index : (y!.Length + Index), Count), StringComparison.OrdinalIgnoreCase);
        public override int GetHashCode(string s) => Hashing.GetHashCodeOrdinalIgnoreCase(s.AsSpan(IsLeft ? Index : (s.Length + Index), Count));
    }

    private sealed class JustifiedCaseInsensitiveAsciiSubstringComparer : SubstringComparer
    {
        public override bool Equals(string? x, string? y) => x.AsSpan(IsLeft ? Index : (x!.Length + Index), Count).Equals(y.AsSpan(IsLeft ? Index : (y!.Length + Index), Count), StringComparison.OrdinalIgnoreCase);
        public override int GetHashCode(string s) => Hashing.GetHashCodeOrdinalIgnoreCaseAscii(s.AsSpan(IsLeft ? Index : (s.Length + Index), Count));
    }
}
