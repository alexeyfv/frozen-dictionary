```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-HCJOSR : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=25  

```
| Method           | DictionarySize | Mean      | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------- |--------------- |----------:|----------:|----------:|---------:|--------:|-------:|----------:|------------:|
| **Dictionary**       | **1**              |  **72.53 ns** |  **1.771 ns** |  **2.364 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 1              | 177.47 ns |  2.647 ns |  3.442 ns |    +144% |    3.6% | 0.**1760** |     368 B |        +70% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **2**              |  **88.23 ns** |  **1.653 ns** |  **2.030 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 2              | 200.39 ns |  4.370 ns |  5.834 ns |    +127% |    3.5% | 0.1836 |     384 B |        +78% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **3**              | **110.42 ns** |  **2.568 ns** |  **3.247 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 3              | 226.96 ns |  4.256 ns |  5.682 ns |    +106% |    4.0% | 0.1912 |     400 B |        +85% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **4**              | **133.47 ns** |  **3.521 ns** |  **4.700 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 4              | 274.76 ns |  7.864 ns |  9.945 ns |    +107% |    5.1% | 0.2522 |     528 B |        +61% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **5**              | **155.29 ns** |  **4.880 ns** |  **6.515 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 5              | 295.30 ns | 10.639 ns | 13.834 ns |     +90% |    6.0% | 0.2599 |     544 B |        +66% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **6**              | **174.88 ns** |  **4.207 ns** |  **5.616 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 6              | 316.83 ns |  8.818 ns | 11.771 ns |     +81% |    5.0% | 0.2675 |     560 B |        +71% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **7**              | **198.75 ns** |  **6.201 ns** |  **8.278 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 7              | 344.07 ns |  9.840 ns | 13.137 ns |     +73% |    5.2% | 0.2751 |     576 B |        +76% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **8**              | **227.73 ns** |  **6.659 ns** |  **8.889 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 8              | 419.73 ns | 12.762 ns | 17.037 ns |     +85% |    5.6% | 0.3366 |     704 B |        +60% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **9**              | **268.92 ns** |  **6.391 ns** |  **8.532 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 9              | 451.62 ns | 11.075 ns | 14.785 ns |     +68% |    4.7% | 0.3443 |     720 B |        +64% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **10**             | **276.48 ns** |  **7.781 ns** | **10.387 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 10             | 485.59 ns | 10.450 ns | 13.588 ns |     +76% |    4.4% | 0.3519 |     736 B |        +67% |
