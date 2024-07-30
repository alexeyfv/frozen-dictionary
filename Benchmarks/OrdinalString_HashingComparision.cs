using Benchmark.Benchmarks.DotNetCore;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class OrdinalString_HashingComparision : BenchmarkBase
{
    [ParamsSource(nameof(Generate_10_to_100000))]
    public int DictionarySize { get; set; }
    private string[] _keys = [];
    private KeyAnalyzer.AnalysisResults _analysisResults;
    private readonly EqualityComparer<string> _comparer = EqualityComparer<string>.Default;

    [GlobalSetup]
    public void Initialize()
    {
        _keys = new string[DictionarySize];
        for (int i = 0; i < DictionarySize; i++)
        {
            // we use keys with the same length
            // to avoid LengthBucketsFrozenDictionary creation
            _keys[i] = $"{Guid.NewGuid()}";
        }

        var length = _keys[0].Length;

        _analysisResults = KeyAnalyzer.Analyze(
            _keys.AsSpan(),
            ignoreCase: true,
            minLength: length,
            maxLength: length);
    }

    [Benchmark(Baseline = true)]
    public int Dictionary()
    {
        var sum = 0;
        foreach (var key in _keys)
        {
            sum += _comparer.GetHashCode(key);
        }
        return sum;
    }

    [Benchmark]
    public int FrozenDictionary()
    {
        var sum = 0;
        foreach (var key in _keys)
        {
            var span = key.AsSpan(_analysisResults.HashIndex, _analysisResults.HashCount);
            sum += Hashing.GetHashCodeOrdinal(span);
        }
        return sum;
    }
}
