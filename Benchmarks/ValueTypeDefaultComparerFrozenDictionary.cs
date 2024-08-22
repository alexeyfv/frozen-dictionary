using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class ValueTypeDefaultComparerFrozenDictionary : BenchmarkBase
{
    [ParamsSource(nameof(GenerateLarge))]
    public int DictionarySize { get; set; }
    public record struct CustomKey(int Value);
    public CustomKey[] collection = [];
    private Dictionary<CustomKey, int> _dictionary = default!;
    private FrozenDictionary<CustomKey, int> _frozenDictionary = default!;

    [GlobalSetup]
    public void Initialize()
    {
        collection = new CustomKey[DictionarySize];
        for (int i = 0; i < DictionarySize; i++) collection[i] = new(i);

        _dictionary = collection.ToDictionary(x => x, x => x.Value * 2);

        _frozenDictionary = collection.ToFrozenDictionary(x => x, x => x.Value * 2);

        if (_frozenDictionary.GetType().Name != "ValueTypeDefaultComparerFrozenDictionary`2")
        {
            throw new Exception($"Invalid FrozenDictionary type: {_frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public int Dictionary()
    {
        var sum = 0;
        for (int i = 0; i < DictionarySize; i++)
        {
            sum += _dictionary[collection[i]];
        }
        return sum;
    }

    [Benchmark]
    public int FrozenDictionary()
    {
        var sum = 0;
        for (int i = 0; i < DictionarySize; i++)
        {
            sum += _frozenDictionary[collection[i]];
        }
        return sum;
    }
}
