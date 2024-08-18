```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-RUOGQI : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method           | DictionarySize | Mean     | Error    | StdDev   | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |---------:|---------:|---------:|---------:|--------:|----------:|------------:|
| Dictionary       | 1              | 19.08 ns | 0.709 ns | 0.946 ns | baseline |         |         - |          NA |
| FrozenDictionary | 1              | 10.20 ns | 0.292 ns | 0.390 ns |     -46% |    6.1% |         - |          NA |
|                  |                |          |          |          |          |         |           |             |
| Dictionary       | 2              | 37.96 ns | 0.919 ns | 1.227 ns | baseline |         |         - |          NA |
| FrozenDictionary | 2              | 23.64 ns | 0.400 ns | 0.533 ns |     -38% |    4.4% |         - |          NA |
|                  |                |          |          |          |          |         |           |             |
| Dictionary       | 3              | 55.46 ns | 1.391 ns | 1.857 ns | baseline |         |         - |          NA |
| FrozenDictionary | 3              | 45.17 ns | 1.101 ns | 1.469 ns |     -18% |    5.7% |         - |          NA |
|                  |                |          |          |          |          |         |           |             |
| Dictionary       | 4              | 86.93 ns | 1.627 ns | 2.172 ns | baseline |         |         - |          NA |
| FrozenDictionary | 4              | 81.41 ns | 6.234 ns | 7.656 ns |      -6% |    8.9% |         - |          NA |
