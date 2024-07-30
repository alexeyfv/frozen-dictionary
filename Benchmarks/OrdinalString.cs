using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class OrdinalString : BenchmarkBase
{
    [ParamsSource(nameof(Generate_10_to_100000))]
    public int DictionarySize { get; set; }

    private Dictionary<string, int> _dictionary = default!;
    private FrozenDictionary<string, int> _frozenDictionary = default!;
    private string[] _keys = [];

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

        _dictionary = _keys.Select((s, i) => (s, i)).ToDictionary(x => x.s, x => x.i);
        _frozenDictionary = _keys.Select((s, i) => (s, i)).ToFrozenDictionary(x => x.s, x => x.i);

        if (_frozenDictionary.GetType().Name != "OrdinalStringFrozenDictionary_LeftJustifiedSubstring`1")
        {
            throw new Exception($"Invalid FrozenDictionary type: {_frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public int Dictionary()
    {
        var sum = 0;
        foreach (var key in _keys)
        {
            sum += _dictionary[key];
        }
        return sum;
    }

    [Benchmark]
    public int FrozenDictionary()
    {
        var sum = 0;
        foreach (var key in _keys)
        {
            sum += _frozenDictionary[key];
        }
        return sum;
    }
}

