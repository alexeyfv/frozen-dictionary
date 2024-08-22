using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 30)]
public class Int32FrozenDictionary : BenchmarkBase
{
    [ParamsSource(nameof(GenerateLarge))]
    public int DictionarySize { get; set; }
    public record MyClass(int Id, int Sum);
    private Dictionary<int, MyClass> _dictionary = default!;
    private FrozenDictionary<int, MyClass> _frozenDictionary = default!;

    [GlobalSetup]
    public void Initialize()
    {
        var collectionForDictionary = new MyClass[DictionarySize];

        for (int i = 0; i < DictionarySize; i++)
        {
            collectionForDictionary[i] = new(i, i + i);
        }

        _dictionary = collectionForDictionary.ToDictionary(x => x.Id);

        var collectionForFrozenDictionary = new MyClass[DictionarySize];

        for (int i = 0; i < DictionarySize; i++)
        {
            collectionForFrozenDictionary[i] = new(i, i + i);
        }

        _frozenDictionary = collectionForFrozenDictionary.ToFrozenDictionary(x => x.Id);

        if (_frozenDictionary.GetType().Name != "Int32FrozenDictionary`1")
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
            sum += _dictionary[i].Sum;
        }
        return sum;
    }

    [Benchmark]
    public int FrozenDictionary()
    {
        var sum = 0;
        for (int i = 0; i < DictionarySize; i++)
        {
            sum += _frozenDictionary[i].Sum;
        }
        return sum;
    }
}
