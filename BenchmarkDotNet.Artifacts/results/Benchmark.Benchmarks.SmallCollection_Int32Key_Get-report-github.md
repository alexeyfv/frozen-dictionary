```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TDIUUG : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=30  

```
| Method           | DictionarySize | Mean      | Error    | StdDev   | Median    | Ratio    | RatioSD | Allocated | Alloc Ratio |
|----------------- |--------------- |----------:|---------:|---------:|----------:|---------:|--------:|----------:|------------:|
| **Dictionary**       | **2**              |  **12.66 ns** | **0.461 ns** | **0.690 ns** |  **12.47 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 2              |  10.97 ns | 0.324 ns | 0.484 ns |  10.77 ns |     -13% |    7.5% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **3**              |  **18.01 ns** | **0.487 ns** | **0.729 ns** |  **17.74 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 3              |  18.51 ns | 0.664 ns | 0.994 ns |  18.25 ns |      +3% |    6.6% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **4**              |  **23.77 ns** | **0.676 ns** | **1.012 ns** |  **23.43 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 4              |  27.05 ns | 0.823 ns | 1.206 ns |  26.92 ns |     +14% |    6.3% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **5**              |  **29.51 ns** | **0.849 ns** | **1.271 ns** |  **29.29 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 5              |  41.80 ns | 1.534 ns | 2.249 ns |  41.36 ns |     +42% |    6.1% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **6**              |  **35.14 ns** | **1.052 ns** | **1.543 ns** |  **34.45 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 6              |  56.13 ns | 1.726 ns | 2.530 ns |  55.64 ns |     +60% |    6.3% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **7**              |  **41.21 ns** | **1.173 ns** | **1.755 ns** |  **40.33 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 7              |  78.85 ns | 2.371 ns | 3.476 ns |  78.43 ns |     +92% |    6.2% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **8**              |  **46.21 ns** | **1.296 ns** | **1.940 ns** |  **44.92 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 8              |  98.25 ns | 3.415 ns | 5.111 ns |  96.47 ns |    +113% |    7.3% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **9**              |  **52.04 ns** | **1.188 ns** | **1.778 ns** |  **51.28 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 9              | 128.24 ns | 3.836 ns | 5.742 ns | 126.69 ns |    +147% |    4.7% |         - |          NA |
|                  |                |           |          |          |           |          |         |           |             |
| **Dictionary**       | **10**             |  **59.13 ns** | **1.670 ns** | **2.500 ns** |  **58.65 ns** | **baseline** |        **** |         **-** |          **NA** |
| FrozenDictionary | 10             | 154.19 ns | 4.547 ns | 6.805 ns | 152.12 ns |    +161% |    6.2% |         - |          NA |
