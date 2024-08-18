using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class SmallValueTypeComparableFrozenDictionary : BenchmarkBase
{
    [ParamsSource(nameof(GenerateSmall))]
    public int DictionarySize { get; set; }
    public int[] collection = [];
    private Dictionary<int, int> _dictionary = default!;
    private FrozenDictionary<int, int> _frozenDictionary = default!;

    [GlobalSetup]
    public void Initialize()
    {
        collection = new int[DictionarySize];

        for (int i = 0; i < DictionarySize; i++)
        {
            collection[i] = i; 
        }

        _dictionary = collection.ToDictionary(x => x, x => x * 2);
        _frozenDictionary = collection.ToFrozenDictionary(x => x, x => x * 2);

        if (_frozenDictionary.GetType().Name != "SmallValueTypeComparableFrozenDictionary`2")
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
