using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class SmallFrozenDictionary : BenchmarkBase
{
    [ParamsSource(nameof(GenerateSmall1to4))]
    public int DictionarySize { get; set; }
    public CustomKey[] collection = [];
    public record CustomKey(int Value);
    private Dictionary<CustomKey, int> _dictionary = default!;
    private FrozenDictionary<CustomKey, int> _frozenDictionary = default!;

    [GlobalSetup]
    public void Initialize()
    {
        collection = new CustomKey[DictionarySize];

        for (int i = 0; i < DictionarySize; i++)
        {
            collection[i] = new(i);
        }

        _dictionary = collection.ToDictionary(x => x, x => x.Value * 2);
        _frozenDictionary = collection.ToFrozenDictionary(x => x, x => x.Value * 2);

        if (_frozenDictionary.GetType().Name != "SmallFrozenDictionary`2")
        {
            throw new Exception($"Invalid FrozenDictionary type: {_frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public int Dictionary()
    {
        var sum = 0;
        for (int i = 0; i < collection.Length; i++)
        {
            sum += _dictionary[collection[i]];
        }
        return sum;
    }

    [Benchmark]
    public int FrozenDictionary()
    {
        var sum = 0;
        for (int i = 0; i < collection.Length; i++)
        {
            sum += _frozenDictionary[collection[i]];
        }
        return sum;
    }
}
