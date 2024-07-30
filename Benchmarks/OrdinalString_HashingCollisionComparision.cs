using System.Text;
using Benchmark.Benchmarks.DotNetCore;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class OrdinalString_HashingCollisionComparision : BenchmarkBase
{
    [Benchmark]
    public void Benchmark()
    {
        var sb = new StringBuilder();

        var dictionaryCollisions = new Dictionary<int, int>();
        var frozenDictionaryCollisions = new Dictionary<int, int>();

        var comparer = EqualityComparer<string>.Default;

        sb.AppendLine("| Size | Dictionary | FrozenDictionary | Substring Length |");
        sb.AppendLine("| - | - | - | - |");

        foreach (var dictionarySize in Generate_10_to_100000())
        {
            dictionaryCollisions.Clear();
            frozenDictionaryCollisions.Clear();

            var keys = new string[dictionarySize];

            for (int i = 0; i < dictionarySize; i++)
            {
                keys[i] = $"{Guid.NewGuid()}";
            }

            var length = keys[0].Length;

            var analysisResults = KeyAnalyzer.Analyze(
                keys.AsSpan(),
                ignoreCase: true,
                minLength: length,
                maxLength: length);

            // Dictionary
            foreach (var key in keys)
            {
                var hashCode = comparer.GetHashCode(key);
                var count = dictionaryCollisions.GetValueOrDefault(hashCode, 0);
                if (count == 0) dictionaryCollisions.Add(hashCode, 1);
                else dictionaryCollisions[hashCode] = count + 1;
            }

            // FrozenDictionary
            foreach (var key in keys)
            {
                var hashCode = Hashing.GetHashCodeOrdinal(key.AsSpan(analysisResults.HashIndex, analysisResults.HashCount)); ;
                var count = frozenDictionaryCollisions.GetValueOrDefault(hashCode, 0);
                if (count == 0) frozenDictionaryCollisions.Add(hashCode, 1);
                else frozenDictionaryCollisions[hashCode] = count + 1;
            }

            sb.AppendFormat("| {0} | {1} | {2} | {3} |",
                dictionarySize,
                dictionaryCollisions.Where(x => x.Value > 1).Count(),
                frozenDictionaryCollisions.Where(x => x.Value > 1).Count(),
                analysisResults.HashCount
                );

            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());
    }
}
