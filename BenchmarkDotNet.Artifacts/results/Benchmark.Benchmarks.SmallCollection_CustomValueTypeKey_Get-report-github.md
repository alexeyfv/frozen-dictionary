```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TDIUUG : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=30  

```
| Method           | DictionarySize | Mean      | Error     | StdDev    | Median    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |----------:|----------:|----------:|----------:|---------:|--------:|----------:|------------:|
| **Dictionary**       | **2**              |  **9.827 ns** | **0.3195 ns** | **0.4781 ns** |  **9.699 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 2              |  6.911 ns | 0.2479 ns | 0.3710 ns |  6.861 ns |     -30% |    7.0% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **3**              | **15.881 ns** | **0.4606 ns** | **0.6895 ns** | **15.658 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 3              | 10.725 ns | 0.3558 ns | 0.5326 ns | 10.585 ns |     -32% |    6.3% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **4**              | **17.918 ns** | **0.5051 ns** | **0.7560 ns** | **17.691 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 4              | 14.463 ns | 0.4659 ns | 0.6974 ns | 14.207 ns |     -19% |    6.5% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **5**              | **21.477 ns** | **0.6324 ns** | **0.9466 ns** | **21.069 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 5              | 19.873 ns | 0.5801 ns | 0.8683 ns | 19.412 ns |      -7% |    7.1% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **6**              | **27.088 ns** | **0.8435 ns** | **1.2624 ns** | **26.704 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 6              | 24.647 ns | 0.5858 ns | 0.8768 ns | 24.550 ns |      -9% |    5.7% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **7**              | **30.459 ns** | **0.8592 ns** | **1.2860 ns** | **30.225 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 7              | 29.801 ns | 0.6992 ns | 0.9802 ns | 29.385 ns |      -2% |    4.3% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **8**              | **33.626 ns** | **1.1042 ns** | **1.6527 ns** | **33.223 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 8              | 35.582 ns | 0.4687 ns | 0.6570 ns | 35.275 ns |      +5% |    5.0% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **9**              | **38.546 ns** | **1.2182 ns** | **1.8233 ns** | **37.767 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 9              | 43.016 ns | 1.1990 ns | 1.7946 ns | 42.142 ns |     +12% |    6.9% |         - |          NA |
|                  |                |           |           |           |           |          |         |           |             |
| **Dictionary**       | **10**             | **41.245 ns** | **1.0976 ns** | **1.6088 ns** | **40.503 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 10             | 50.514 ns | 1.2087 ns | 1.8091 ns | 50.146 ns |     +23% |    4.2% |         - |          NA |
