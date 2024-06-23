using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class SmallCollection_Int32Key_Create : BenchmarkBase
{
    [ParamsSource(nameof(GenerateSmall))]
    public int DictionarySize { get; set; }
    public record MyClass(int Id, int Sum);
    private MyClass[] _collection = default!;

    [GlobalSetup]
    public void Initialize()
    {
        _collection = new MyClass[DictionarySize];
        for (int i = 0; i < DictionarySize; i++)
        {
            _collection[i] = new(i, i + i);
        }

        var frozenDictionary = _collection.ToFrozenDictionary(x => x.Id);

        if (frozenDictionary.GetType().Name != "SmallValueTypeComparableFrozenDictionary`2")
        {
            throw new Exception($"Invalid FrozenDictionary type: {frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);

    [Benchmark]
    public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
}
