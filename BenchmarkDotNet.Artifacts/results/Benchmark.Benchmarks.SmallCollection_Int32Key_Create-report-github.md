```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TDIUUG : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=30  

```
| Method           | DictionarySize | Mean      | Error     | StdDev    | Ratio    | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------- |--------------- |----------:|----------:|----------:|---------:|--------:|-------:|----------:|------------:|
| **Dictionary**       | **2**              |  **67.77 ns** |  **2.659 ns** |  **3.980 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 2              | 208.23 ns |  2.976 ns |  4.074 ns |    +208% |    6.0% | 0.1836 |     384 B |        +78% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **3**              |  **76.59 ns** |  **2.206 ns** |  **3.302 ns** | **baseline** |        **** | **0.1032** |     **216 B** |            **** |
| FrozenDictionary | 3              | 232.59 ns |  6.622 ns |  9.911 ns |    +204% |    5.1% | 0.1912 |     400 B |        +85% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **4**              |  **92.75 ns** |  **2.669 ns** |  **3.995 ns** | **baseline** |        **** | **0.1568** |     **328 B** |            **** |
| FrozenDictionary | 4              | 265.33 ns |  7.640 ns | 11.435 ns |    +187% |    6.0% | 0.2484 |     520 B |        +59% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **5**              | **102.71 ns** |  **2.603 ns** |  **3.896 ns** | **baseline** |        **** | **0.1568** |     **328 B** |            **** |
| FrozenDictionary | 5              | 273.15 ns |  4.659 ns |  6.682 ns |    +167% |    4.5% | 0.2561 |     536 B |        +63% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **6**              | **109.65 ns** |  **3.244 ns** |  **4.855 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 6              | 303.34 ns |  7.884 ns | 11.801 ns |    +177% |    5.4% | 0.2599 |     544 B |        +66% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **7**              | **118.87 ns** |  **3.589 ns** |  **5.373 ns** | **baseline** |        **** | **0.1566** |     **328 B** |            **** |
| FrozenDictionary | 7              | 320.70 ns |  6.500 ns |  9.323 ns |    +171% |    5.7% | 0.2675 |     560 B |        +71% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **8**              | **149.74 ns** |  **4.142 ns** |  **6.199 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 8              | 364.04 ns | 10.757 ns | 16.101 ns |    +144% |    6.0% | 0.3247 |     680 B |        +55% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **9**              | **159.98 ns** |  **4.501 ns** |  **6.737 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 9              | 394.78 ns |  9.581 ns | 14.341 ns |    +147% |    5.8% | 0.3328 |     696 B |        +58% |
|                  |                |           |           |           |          |         |        |           |             |
| **Dictionary**       | **10**             | **168.17 ns** |  **5.455 ns** |  **8.165 ns** | **baseline** |        **** | **0.2103** |     **440 B** |            **** |
| FrozenDictionary | 10             | 393.60 ns | 10.559 ns | 15.804 ns |    +134% |    5.1% | 0.3366 |     704 B |        +60% |
