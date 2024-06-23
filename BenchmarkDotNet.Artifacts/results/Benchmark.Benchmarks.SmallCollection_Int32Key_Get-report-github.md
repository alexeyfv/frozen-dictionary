```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HCJOSR : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method           | DictionarySize | Mean       | Error     | StdDev    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |-----------:|----------:|----------:|---------:|--------:|----------:|------------:|
| **Dictionary**       | **1**              |   **6.252 ns** | **0.2669 ns** | **0.3563 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 1              |   3.270 ns | 0.0306 ns | 0.0352 ns |     -47% |    5.2% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **2**              |  **12.294 ns** | **0.3684 ns** | **0.4918 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 2              |  12.134 ns | 0.2348 ns | 0.2969 ns |      -1% |    3.7% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **3**              |  **18.172 ns** | **0.6032 ns** | **0.7844 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 3              |  18.393 ns | 0.5759 ns | 0.7688 ns |      +2% |    6.9% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **4**              |  **23.563 ns** | **0.6599 ns** | **0.8581 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 4              |  27.730 ns | 1.4286 ns | 1.9071 ns |     +18% |    8.0% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **5**              |  **29.664 ns** | **1.0071 ns** | **1.3095 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 5              |  42.588 ns | 1.4455 ns | 1.9297 ns |     +44% |    5.0% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **6**              |  **35.692 ns** | **1.0832 ns** | **1.4460 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 6              |  54.000 ns | 2.1803 ns | 2.9106 ns |     +52% |    8.1% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **7**              |  **41.157 ns** | **1.1158 ns** | **1.4895 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 7              |  83.791 ns | 2.0261 ns | 2.7048 ns |    +104% |    4.9% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **8**              |  **47.424 ns** | **1.2736 ns** | **1.7002 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 8              |  89.972 ns | 2.5031 ns | 3.3415 ns |     +90% |    3.5% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **9**              |  **51.949 ns** | **1.7063 ns** | **2.2779 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 9              | 120.924 ns | 3.1637 ns | 4.2235 ns |    +133% |    6.3% |         - |          NA |
|                  |                |            |           |           |          |         |           |             |
| **Dictionary**       | **10**             |  **55.372 ns** | **0.4603 ns** | **0.5480 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 10             | 158.297 ns | 5.5347 ns | 7.3887 ns |    +184% |    3.8% |         - |          NA |
