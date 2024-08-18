```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-RUOGQI : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method           | DictionarySize | Mean       | Error     | StdDev    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |-----------:|----------:|----------:|---------:|--------:|----------:|------------:|
| Dictionary       | 1              |   7.891 ns | 0.1321 ns | 0.1718 ns | baseline |         |         - |          NA |
| FrozenDictionary | 1              |   4.135 ns | 0.2071 ns | 0.2765 ns |     -48% |    7.7% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 2              |  13.542 ns | 0.5935 ns | 0.7923 ns | baseline |         |         - |          NA |
| FrozenDictionary | 2              |  12.647 ns | 0.3715 ns | 0.4698 ns |      -6% |    7.0% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 3              |  19.766 ns | 0.5380 ns | 0.7182 ns | baseline |         |         - |          NA |
| FrozenDictionary | 3              |  20.032 ns | 0.4985 ns | 0.6305 ns |      +2% |    4.9% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 4              |  25.431 ns | 0.7356 ns | 0.9821 ns | baseline |         |         - |          NA |
| FrozenDictionary | 4              |  29.207 ns | 1.0068 ns | 1.3441 ns |     +15% |    5.7% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 5              |  31.526 ns | 0.9681 ns | 1.2923 ns | baseline |         |         - |          NA |
| FrozenDictionary | 5              |  44.254 ns | 1.2095 ns | 1.6147 ns |     +41% |    5.3% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 6              |  37.704 ns | 1.5181 ns | 2.0266 ns | baseline |         |         - |          NA |
| FrozenDictionary | 6              |  55.726 ns | 1.8910 ns | 2.5245 ns |     +48% |    6.9% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 7              |  44.427 ns | 1.6325 ns | 2.1793 ns | baseline |         |         - |          NA |
| FrozenDictionary | 7              |  85.218 ns | 2.7622 ns | 3.6875 ns |     +92% |    7.0% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 8              |  50.880 ns | 1.0310 ns | 1.3763 ns | baseline |         |         - |          NA |
| FrozenDictionary | 8              |  96.811 ns | 2.4222 ns | 3.2335 ns |     +90% |    4.3% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 9              |  55.676 ns | 1.9430 ns | 2.5938 ns | baseline |         |         - |          NA |
| FrozenDictionary | 9              | 123.473 ns | 3.0066 ns | 4.0137 ns |    +122% |    6.2% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| Dictionary       | 10             |  63.243 ns | 1.8349 ns | 2.4496 ns | baseline |         |         - |          NA |
| FrozenDictionary | 10             | 164.568 ns | 4.9407 ns | 6.5957 ns |    +160% |    4.5% |         - |          NA |
