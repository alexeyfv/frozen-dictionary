using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class LengthBuckets : BenchmarkBase
{
    [ParamsSource(nameof(Generate_10_to_50000))]
    public int DictionarySize { get; set; }

    [Params(1, 2, 3, 4, 5)]
    public int KeysPerBucket { get; set; }

    private Dictionary<string, int> _dictionary = default!;
    private FrozenDictionary<string, int> _frozenDictionary = default!;
    private List<string> _keys = default!;

    [GlobalSetup]
    public void Initialize()
    {
        _keys = new List<string>(KeysPerBucket * KeysPerBucket);

        for (int i = 1; i <= DictionarySize; i++)
        {
            if (KeysPerBucket >= 1) _keys.Add(new string('a', i));
            if (KeysPerBucket >= 2) _keys.Add(new string('b', i));
            if (KeysPerBucket >= 3) _keys.Add(new string('c', i));
            if (KeysPerBucket >= 4) _keys.Add(new string('d', i));
            if (KeysPerBucket >= 5) _keys.Add(new string('e', i));
        }

        _dictionary = _keys.Select((s, i) => (s, i)).ToDictionary(x => x.s, x => x.i);
        _frozenDictionary = _keys.Select((s, i) => (s, i)).ToFrozenDictionary(x => x.s, x => x.i);

        if (_frozenDictionary.GetType().Name != "LengthBucketsFrozenDictionary`1")
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
