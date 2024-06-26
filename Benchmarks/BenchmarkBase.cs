namespace Benchmark.Benchmarks;

public abstract class BenchmarkBase
{
    public IEnumerable<int> GenerateSmall()
    {
        for (int i = 1; i <= 10; i++)
        {
            yield return i;
        }
    }

    public IEnumerable<int> GenerateLarge()
    {
        yield return 11;
        for (int i = 100; i < 1_000; i += 36) yield return i;
        for (int i = 1_000; i < 10_000; i += 360) yield return i;
        for (int i = 10_000; i < 100_000; i += 3_600) yield return i;
        for (int i = 100_000; i <= 1_000_000; i += 36_000) yield return i;
    }
}
