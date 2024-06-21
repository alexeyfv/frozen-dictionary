using System.Collections.Frozen;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace Benchmark.Benchmarks;

[CategoriesColumn]
[MemoryDiagnoser]
// [DisassemblyDiagnoser(printSource: true, maxDepth: 2, exportCombinedDisassemblyReport: true)]
[SimpleJob(iterationCount: 30)]
public class LargeCollection_Int32Key_Create
{
    [Params(11, 20, 30, 40, 50, 60, 70, 80, 90, 
        100, 200, 300, 400, 500, 600, 700, 800, 900, 
        1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000,
        10_000, 20_000, 30_000, 40_000, 50_000, 60_000, 70_000, 80_000, 90_000, 100_000)]
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

        if (frozenDictionary.GetType().Name != "Int32FrozenDictionary`1")
        {
            throw new Exception($"Invalid FrozenDictionary type: {frozenDictionary.GetType().Name}");
        }
    }

    [Benchmark(Baseline = true)]
    public Dictionary<int, MyClass> Dictionary() => _collection.ToDictionary(x => x.Id);

    [Benchmark]
    public FrozenDictionary<int, MyClass> FrozenDictionary() => _collection.ToFrozenDictionary(x => x.Id);
}
