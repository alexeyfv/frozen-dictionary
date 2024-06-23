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
| **Dictionary**       | **1**              |  **59.50 ns** |  **1.353 ns** |  **1.807 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 1              | 171.44 ns |  4.880 ns |  6.514 ns |    +188% |    4.2% | 0.1798 |     376 B |        +74% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **2**              |  **68.53 ns** |  **2.630 ns** |  **3.511 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 2              | 208.49 ns |  6.970 ns |  9.304 ns |    +205% |    6.1% | 0.1836 |     384 B |        +78% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **3**              |  **76.40 ns** |  **2.404 ns** |  **3.209 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 3              | 229.60 ns |  3.074 ns |  3.888 ns |    +200% |    4.5% | 0.1912 |     400 B |        +85% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **4**              |  **92.58 ns** |  **2.366 ns** |  **3.158 ns** | **baseline** |        **** | **0.1568** |     **328 B** |            **** |
| FrozenDictionary | 4              | 257.32 ns |  7.005 ns |  9.351 ns |    +178% |    5.0% | 0.2484 |     520 B |        +59% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **5**              | **114.17 ns** |  **3.315 ns** |  **4.426 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 5              | 284.53 ns |  6.874 ns |  8.938 ns |    +150% |    4.7% | 0.2561 |     536 B |        +63% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **6**              | **111.63 ns** |  **4.013 ns** |  **5.357 ns** | **baseline** |        **** | **0.1568** |     **328 B** |            **** |
| FrozenDictionary | 6              | 298.55 ns |  7.332 ns |  9.788 ns |    +168% |    5.8% | 0.2599 |     544 B |        +66% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **7**              | **122.16 ns** |  **3.273 ns** |  **4.369 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 7              | 322.21 ns |  8.881 ns | 11.548 ns |    +163% |    3.9% | 0.2675 |     560 B |        +71% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **8**              | **162.63 ns** |  **4.564 ns** |  **5.935 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 8              | 369.65 ns | 10.332 ns | 13.792 ns |    +128% |    4.6% | 0.3247 |     680 B |        +55% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **9**              | **159.46 ns** |  **5.418 ns** |  **7.233 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 9              | 383.84 ns | 10.792 ns | 14.032 ns |    +141% |    5.3% | 0.3328 |     696 B |        +58% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **10**             | **168.39 ns** |  **6.603 ns** |  **8.815 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 10             | 392.01 ns | 10.706 ns | 14.293 ns |    +133% |    5.4% | 0.3366 |     704 B |        +60% |
