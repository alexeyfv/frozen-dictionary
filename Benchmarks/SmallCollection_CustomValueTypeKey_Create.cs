using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 25)]
public class SmallCollection_CustomValueTypeKey_Create : BenchmarkBase
{
    [ParamsSource(nameof(GenerateSmall))]
    public int DictionarySize { get; set; }
    public record struct CustomKey(int A, int B);
    public record MyClass(CustomKey Id, int Sum);
    private MyClass[] _collection = default!;

    [GlobalSetup]
    public void Initialize()
    {
        _collection = new MyClass[DictionarySize];
        for (int i = 0; i < DictionarySize; i++)
        {
            _collection[i] = new(new(i, i), i + i);
        }

        var frozenDictionary = _collection.ToFrozenDictionary(x => x.Id);

        if (frozenDictionary.GetType().Name != "SmallValueTypeDefaultComparerFrozenDictionary`2")
        {
            throw new Exception($"Invalid FrozenDictionary type: {frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public Dictionary<CustomKey, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);

    [Benchmark]
    public FrozenDictionary<CustomKey, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
}
