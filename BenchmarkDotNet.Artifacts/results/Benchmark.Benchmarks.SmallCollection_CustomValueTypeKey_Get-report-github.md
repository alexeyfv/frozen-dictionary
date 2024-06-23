```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HCJOSR : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method           | DictionarySize | Mean      | Error     | StdDev    | Median    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |----------:|----------:|----------:|----------:|---------:|--------:|----------:|------------:|
| **Dictionary**       | **1**              |  **5.517 ns** | **0.2174 ns** | **0.2827 ns** |  **5.593 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 1              |  3.225 ns | 0.1448 ns | 0.1933 ns |  3.107 ns |     -41% |    6.7% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **2**              |  **9.663 ns** | **0.3384 ns** | **0.4401 ns** |  **9.507 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 2              |  6.908 ns | 0.2621 ns | 0.3499 ns |  6.806 ns |     -28% |    7.1% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **3**              | **15.257 ns** | **0.4943 ns** | **0.6599 ns** | **14.869 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 3              | 10.425 ns | 0.3520 ns | 0.4699 ns | 10.313 ns |     -32% |    5.1% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **4**              | **18.034 ns** | **0.5406 ns** | **0.7216 ns** | **18.044 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 4              | 13.886 ns | 0.5221 ns | 0.6969 ns | 13.721 ns |     -23% |    6.6% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **5**              | **21.564 ns** | **0.7037 ns** | **0.9394 ns** | **21.721 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 5              | 19.268 ns | 0.6851 ns | 0.9145 ns | 18.832 ns |     -10% |    6.8% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **6**              | **25.681 ns** | **0.4251 ns** | **0.5527 ns** | **25.563 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 6              | 24.338 ns | 0.8189 ns | 1.0932 ns | 24.003 ns |      -5% |    5.0% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **7**              | **31.158 ns** | **0.4689 ns** | **0.5930 ns** | **31.130 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 7              | 29.870 ns | 1.0780 ns | 1.4391 ns | 29.130 ns |      -5% |    5.1% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **8**              | **32.120 ns** | **0.8064 ns** | **1.0485 ns** | **31.457 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 8              | 34.635 ns | 0.1583 ns | 0.1944 ns | 34.618 ns |      +8% |    3.2% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **9**              | **37.357 ns** | **1.2500 ns** | **1.6688 ns** | **36.430 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 9              | 41.360 ns | 0.2373 ns | 0.2732 ns | 41.376 ns |     +10% |    4.7% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **10**             | **40.361 ns** | **0.5418 ns** | **0.6450 ns** | **40.146 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 10             | 49.305 ns | 1.1637 ns | 1.5132 ns | 48.639 ns |     +22% |    3.8% |         - |          NA |
