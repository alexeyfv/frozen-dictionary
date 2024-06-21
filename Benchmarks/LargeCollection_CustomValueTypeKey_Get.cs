using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 30)]
public class LargeCollection_CustomValueTypeKey_Get
{
    [Params(11, 20, 30, 40, 50, 60, 70, 80, 90, 
        100, 200, 300, 400, 500, 600, 700, 800, 900, 
        1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000,
        10_000, 20_000, 30_000, 40_000, 50_000, 60_000, 70_000, 80_000, 90_000, 100_000)]
    public int DictionarySize { get; set; }
    public record struct CustomKey(int A, int B);
    public record MyClass(CustomKey Id, int Sum);
    private Dictionary<CustomKey, MyClass> _dictionary = default!;
    private FrozenDictionary<CustomKey, MyClass> _frozenDictionary = default!;

    [GlobalSetup]
    public void Initialize()
    {
        var collectionForDictionary = new MyClass[DictionarySize];

        for (int i = 0; i < DictionarySize; i++)
        {
            collectionForDictionary[i] = new(new(i, i), i + i);
        }

        _dictionary = collectionForDictionary.ToDictionary(x => x.Id);

        var collectionForFrozenDictionary = new MyClass[DictionarySize];

        for (int i = 0; i < DictionarySize; i++)
        {
            collectionForFrozenDictionary[i] = new(new(i, i), i + i);
        }

        _frozenDictionary = collectionForFrozenDictionary.ToFrozenDictionary(x => x.Id);

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
            sum += _dictionary[new(i, i)].Sum;
        }
        return sum;
    }

    [Benchmark]
    public int FrozenDictionary()
    {
        var sum = 0;
        for (int i = 0; i < DictionarySize; i++)
        {
            sum += _frozenDictionary[new(i, i)].Sum;
        }
        return sum;
    }
}
