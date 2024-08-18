```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-RUOGQI : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method           | DictionarySize | Mean      | Error     | StdDev    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |----------:|----------:|----------:|---------:|--------:|----------:|------------:|
| Dictionary       | 1              |  5.774 ns | 0.2663 ns | 0.3555 ns | baseline |         |         - |          NA |
| FrozenDictionary | 1              |  3.658 ns | 0.1577 ns | 0.2106 ns |     -36% |    8.7% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 2              |  8.999 ns | 0.3202 ns | 0.4275 ns | baseline |         |         - |          NA |
| FrozenDictionary | 2              |  7.069 ns | 0.1334 ns | 0.1734 ns |     -21% |    5.9% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 3              | 12.652 ns | 0.4959 ns | 0.6620 ns | baseline |         |         - |          NA |
| FrozenDictionary | 3              | 11.235 ns | 0.4364 ns | 0.5825 ns |     -11% |    7.1% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 4              | 16.486 ns | 0.5367 ns | 0.7165 ns | baseline |         |         - |          NA |
| FrozenDictionary | 4              | 16.089 ns | 0.5919 ns | 0.7901 ns |      -2% |    6.3% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 5              | 19.819 ns | 0.5865 ns | 0.7626 ns | baseline |         |         - |          NA |
| FrozenDictionary | 5              | 20.343 ns | 0.6764 ns | 0.9030 ns |      +3% |    6.1% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 6              | 23.386 ns | 0.7146 ns | 0.9540 ns | baseline |         |         - |          NA |
| FrozenDictionary | 6              | 24.353 ns | 0.7124 ns | 0.9510 ns |      +4% |    5.8% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 7              | 27.138 ns | 0.8946 ns | 1.1942 ns | baseline |         |         - |          NA |
| FrozenDictionary | 7              | 29.895 ns | 0.8297 ns | 1.1076 ns |     +10% |    5.6% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 8              | 31.558 ns | 1.1738 ns | 1.5670 ns | baseline |         |         - |          NA |
| FrozenDictionary | 8              | 34.239 ns | 0.9931 ns | 1.3258 ns |      +9% |    6.1% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 9              | 34.312 ns | 1.1936 ns | 1.5520 ns | baseline |         |         - |          NA |
| FrozenDictionary | 9              | 42.084 ns | 1.0342 ns | 1.3807 ns |     +23% |    5.6% |         - |          NA |
|                  |                |           |           |           |          |         |           |             |
| Dictionary       | 10             | 39.647 ns | 1.0679 ns | 1.3115 ns | baseline |         |         - |          NA |
| FrozenDictionary | 10             | 50.260 ns | 1.3574 ns | 1.8121 ns |     +27% |    4.7% |         - |          NA |
