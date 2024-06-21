```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-TDIUUG : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=30  

```
| Method           | DictionarySize | Mean           | Error         | StdDev        | Median         | Ratio    | RatioSD | Gen0     | Gen1     | Gen2     | Allocated | Alloc Ratio |
|----------------- |--------------- |---------------:|--------------:|--------------:|---------------:|---------:|--------:|---------:|---------:|---------:|----------:|------------:|
| **Dictionary**       | **11**             |       **178.0 ns** |       **5.70 ns** |       **8.53 ns** |       **176.6 ns** | **baseline** |        **** |   **0.2103** |        **-** |        **-** |     **440 B** |            **** |
| FrozenDictionary | 11             |       635.7 ns |      10.12 ns |      14.19 ns |       630.9 ns |    +258% |    5.9% |   0.5198 |        - |        - |    1088 B |       +147% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **20**             |       **284.1 ns** |      **11.10 ns** |      **16.62 ns** |       **278.7 ns** | **baseline** |        **** |   **0.3710** |        **-** |        **-** |     **776 B** |            **** |
| FrozenDictionary | 20             |       904.8 ns |      20.51 ns |      30.06 ns |       891.8 ns |    +221% |    7.4% |   0.8907 |        - |        - |    1864 B |       +140% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **30**             |       **404.7 ns** |      **10.73 ns** |      **15.73 ns** |       **405.4 ns** | **baseline** |        **** |   **0.5579** |        **-** |        **-** |    **1168 B** |            **** |
| FrozenDictionary | 30             |     1,244.2 ns |      30.16 ns |      44.21 ns |     1,232.3 ns |    +208% |    5.3% |   1.3027 |        - |        - |    2728 B |       +134% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **40**             |       **519.5 ns** |      **12.18 ns** |      **18.24 ns** |       **516.9 ns** | **baseline** |        **** |   **0.6914** |        **-** |        **-** |    **1448 B** |            **** |
| FrozenDictionary | 40             |     1,613.4 ns |      39.59 ns |      59.26 ns |     1,617.0 ns |    +211% |    5.4% |   1.6403 |        - |        - |    3432 B |       +137% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **50**             |       **665.0 ns** |      **29.25 ns** |      **43.78 ns** |       **668.6 ns** | **baseline** |        **** |   **0.8526** |        **-** |        **-** |    **1784 B** |            **** |
| FrozenDictionary | 50             |     1,936.9 ns |      55.86 ns |      83.62 ns |     1,922.1 ns |    +193% |    8.4% |   2.0027 |        - |        - |    4192 B |       +135% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **60**             |       **734.1 ns** |      **18.74 ns** |      **28.05 ns** |       **724.1 ns** | **baseline** |        **** |   **1.0128** |        **-** |        **-** |    **2120 B** |            **** |
| FrozenDictionary | 60             |     2,181.6 ns |      54.81 ns |      82.03 ns |     2,166.0 ns |    +197% |    4.6% |   2.3880 |        - |        - |    5000 B |       +136% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **70**             |       **810.3 ns** |      **12.21 ns** |      **17.11 ns** |       **807.7 ns** | **baseline** |        **** |   **1.0128** |        **-** |        **-** |    **2120 B** |            **** |
| FrozenDictionary | 70             |     2,484.4 ns |      66.78 ns |      99.96 ns |     2,456.9 ns |    +206% |    4.1% |   2.6436 |        - |        - |    5536 B |       +161% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **80**             |       **972.2 ns** |      **27.04 ns** |      **40.47 ns** |       **961.4 ns** | **baseline** |        **** |   **1.2531** |        **-** |        **-** |    **2624 B** |            **** |
| FrozenDictionary | 80             |     2,861.1 ns |      77.81 ns |     116.47 ns |     2,808.4 ns |    +195% |    5.8% |   3.0174 |        - |        - |    6320 B |       +141% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **90**             |     **1,090.4 ns** |      **27.89 ns** |      **41.75 ns** |     **1,081.2 ns** | **baseline** |        **** |   **1.4935** |        **-** |        **-** |    **3128 B** |            **** |
| FrozenDictionary | 90             |     3,227.9 ns |      90.31 ns |     135.17 ns |     3,184.6 ns |    +196% |    5.7% |   3.5248 |        - |        - |    7376 B |       +136% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **100**            |     **1,198.9 ns** |      **32.03 ns** |      **47.94 ns** |     **1,196.2 ns** | **baseline** |        **** |   **1.4935** |        **-** |        **-** |    **3128 B** |            **** |
| FrozenDictionary | 100            |     3,515.2 ns |     100.11 ns |     149.84 ns |     3,486.4 ns |    +194% |    6.2% |   3.8185 |        - |        - |    7992 B |       +155% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **200**            |     **2,328.9 ns** |      **59.60 ns** |      **89.21 ns** |     **2,310.8 ns** | **baseline** |        **** |   **3.2539** |        **-** |        **-** |    **6824 B** |            **** |
| FrozenDictionary | 200            |     6,630.5 ns |     163.62 ns |     244.89 ns |     6,563.0 ns |    +185% |    5.9% |   7.6523 |        - |        - |   16024 B |       +135% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **300**            |     **3,414.8 ns** |      **78.19 ns** |     **117.02 ns** |     **3,351.8 ns** | **baseline** |        **** |   **4.7836** |        **-** |        **-** |   **10016 B** |            **** |
| FrozenDictionary | 300            |     9,825.3 ns |     297.79 ns |     445.72 ns |     9,642.6 ns |    +188% |    5.7% |  11.2762 |        - |        - |   23616 B |       +136% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **400**            |     **4,562.6 ns** |     **127.52 ns** |     **190.86 ns** |     **4,542.4 ns** | **baseline** |        **** |   **5.8136** |        **-** |        **-** |   **12200 B** |            **** |
| FrozenDictionary | 400            |    12,805.0 ns |     360.46 ns |     539.52 ns |    12,494.6 ns |    +181% |    6.1% |  14.7552 |        - |        - |   30904 B |       +153% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **500**            |     **5,487.5 ns** |     **142.92 ns** |     **209.49 ns** |     **5,378.6 ns** | **baseline** |        **** |   **6.9885** |        **-** |        **-** |   **14720 B** |            **** |
| FrozenDictionary | 500            |    16,296.0 ns |     520.18 ns |     778.57 ns |    16,100.0 ns |    +198% |    5.7% |  17.9443 |        - |        - |   37696 B |       +156% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **600**            |     **6,718.7 ns** |     **169.80 ns** |     **254.16 ns** |     **6,681.3 ns** | **baseline** |        **** |   **8.4686** |        **-** |        **-** |   **17800 B** |            **** |
| FrozenDictionary | 600            |    19,835.6 ns |     506.24 ns |     757.71 ns |    19,704.5 ns |    +196% |    5.3% |  21.6064 |        - |        - |   45368 B |       +155% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **700**            |     **7,905.4 ns** |     **206.18 ns** |     **308.60 ns** |     **7,832.5 ns** | **baseline** |        **** |  **10.1929** |        **-** |        **-** |   **21440 B** |            **** |
| FrozenDictionary | 700            |    22,176.6 ns |     667.61 ns |     999.24 ns |    21,855.5 ns |    +181% |    6.3% |  25.6348 |        - |        - |   53968 B |       +152% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **800**            |     **9,100.2 ns** |     **293.90 ns** |     **439.89 ns** |     **8,937.6 ns** | **baseline** |        **** |  **12.3444** |        **-** |        **-** |   **25864 B** |            **** |
| FrozenDictionary | 800            |    26,018.1 ns |     653.88 ns |     978.69 ns |    25,836.9 ns |    +186% |    5.6% |  30.2734 |        - |        - |   63864 B |       +147% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **900**            |    **10,038.4 ns** |     **185.47 ns** |     **253.87 ns** |    **10,009.2 ns** | **baseline** |        **** |  **12.3444** |        **-** |        **-** |   **25864 B** |            **** |
| FrozenDictionary | 900            |    29,092.6 ns |     649.47 ns |     972.10 ns |    28,963.4 ns |    +189% |    3.8% |  31.7383 |        - |        - |   66664 B |       +158% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **1000**           |    **11,395.7 ns** |     **348.28 ns** |     **521.28 ns** |    **11,265.2 ns** | **baseline** |        **** |  **14.6942** |        **-** |        **-** |   **31016 B** |            **** |
| FrozenDictionary | 1000           |    32,246.4 ns |     834.30 ns |   1,248.74 ns |    32,001.6 ns |    +184% |    6.3% |  36.9873 |        - |        - |   77832 B |       +151% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **2000**           |    **23,272.5 ns** |     **695.56 ns** |   **1,041.09 ns** |    **23,454.6 ns** | **baseline** |        **** |  **31.2195** |        **-** |        **-** |   **65456 B** |            **** |
| FrozenDictionary | 2000           |    67,989.1 ns |   2,184.52 ns |   3,269.69 ns |    68,017.0 ns |    +193% |    6.3% |  66.6504 |   9.5215 |        - |  154000 B |       +135% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **3000**           |    **34,611.4 ns** |   **1,049.21 ns** |   **1,570.41 ns** |    **34,244.4 ns** | **baseline** |        **** |  **44.4336** |        **-** |        **-** |   **94520 B** |            **** |
| FrozenDictionary | 3000           |    93,453.2 ns |   1,743.34 ns |   2,555.36 ns |    92,003.9 ns |    +170% |    4.5% | 111.0840 |        - |        - |  234776 B |       +148% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **4000**           |   **160,076.8 ns** |   **1,771.90 ns** |   **2,483.96 ns** |   **160,046.9 ns** | **baseline** |        **** |  **30.2734** |  **30.2734** |  **30.2734** |  **113525 B** |            **** |
| FrozenDictionary | 4000           |   258,194.6 ns |   4,332.91 ns |   6,485.30 ns |   257,902.0 ns |     +62% |    3.1% |  90.8203 |  30.2734 |  30.2734 |  293029 B |       +158% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **5000**           |   **207,219.0 ns** |   **1,458.95 ns** |   **2,045.25 ns** |   **207,087.3 ns** | **baseline** |        **** |  **43.4570** |  **43.4570** |  **43.4570** |  **163653 B** |            **** |
| FrozenDictionary | 5000           |   298,571.3 ns |   7,835.19 ns |  11,484.72 ns |   296,199.4 ns |     +44% |    4.4% |  87.4023 |  43.4570 |  43.4570 |  384629 B |       +135% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **6000**           |   **241,028.9 ns** |   **2,465.81 ns** |   **3,690.71 ns** |   **239,372.7 ns** | **baseline** |        **** |  **52.4902** |  **52.4902** |  **52.4902** |  **196531 B** |            **** |
| FrozenDictionary | 6000           |   269,666.5 ns |   1,419.16 ns |   2,124.13 ns |   269,602.3 ns |     +12% |    1.6% | 110.8398 | 110.8398 | 110.8398 |  461867 B |       +135% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **7000**           |   **268,489.4 ns** |   **3,722.82 ns** |   **5,572.15 ns** |   **268,107.6 ns** | **baseline** |        **** |  **52.2461** |  **52.2461** |  **52.2461** |  **196531 B** |            **** |
| FrozenDictionary | 7000           |   614,603.2 ns |   6,539.73 ns |   9,788.36 ns |   615,816.2 ns |    +129% |    2.8% | 124.0234 | 124.0234 | 124.0234 |  509460 B |       +159% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **8000**           |   **311,511.4 ns** |   **2,809.25 ns** |   **4,204.76 ns** |   **312,673.0 ns** | **baseline** |        **** |  **62.0117** |  **62.0117** |  **62.0117** |  **235906 B** |            **** |
| FrozenDictionary | 8000           |   346,185.1 ns |   4,988.89 ns |   7,312.65 ns |   345,300.6 ns |     +11% |    2.6% | 142.5781 | 142.5781 | 142.5781 |  600264 B |       +154% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **9000**           |   **353,590.2 ns** |   **2,631.38 ns** |   **3,857.05 ns** |   **354,230.9 ns** | **baseline** |        **** |  **76.6602** |  **76.6602** |  **76.6602** |  **283068 B** |            **** |
| FrozenDictionary | 9000           |   400,662.8 ns |   7,951.33 ns |  11,901.17 ns |   400,430.3 ns |     +13% |    3.5% | 166.5039 | 166.5039 | 166.5039 |  703464 B |       +149% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **10000**          |   **388,378.8 ns** |   **6,560.15 ns** |   **9,818.92 ns** |   **386,028.8 ns** | **baseline** |        **** |  **76.6602** |  **76.6602** |  **76.6602** |  **283068 B** |            **** |
| FrozenDictionary | 10000          |   661,161.3 ns |   6,054.23 ns |   8,874.21 ns |   660,501.6 ns |     +71% |    2.6% | 175.7813 | 175.7813 | 175.7813 |  731471 B |       +158% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **20000**          |   **761,487.9 ns** |   **5,616.73 ns** |   **7,873.87 ns** |   **760,654.2 ns** | **baseline** |        **** | **142.5781** | **142.5781** | **142.5781** |  **588873 B** |            **** |
| FrozenDictionary | 20000          | 1,285,573.3 ns |  12,999.16 ns |  18,643.00 ns | 1,284,230.9 ns |     +69% |    1.8% | 335.9375 | 296.8750 | 261.7188 | 1499939 B |       +155% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **30000**          |   **659,205.4 ns** |  **11,347.74 ns** |  **16,984.76 ns** |   **662,198.2 ns** | **baseline** |        **** | **126.9531** | **125.9766** | **125.9766** |  **849328 B** |            **** |
| FrozenDictionary | 30000          | 2,119,994.4 ns |  28,274.57 ns |  42,320.04 ns | 2,113,457.2 ns |    +222% |    3.4% | 378.9063 | 375.0000 | 375.0000 | 2194014 B |       +158% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **40000**          |   **902,760.3 ns** |  **14,446.29 ns** |  **19,285.39 ns** |   **895,976.8 ns** | **baseline** |        **** | **333.0078** | **333.0078** | **333.0078** | **1221912 B** |            **** |
| FrozenDictionary | 40000          | 3,535,468.5 ns |  90,237.70 ns | 132,269.25 ns | 3,529,362.7 ns |    +292% |    4.7% | 324.2188 | 324.2188 | 324.2188 | 3068542 B |       +151% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **50000**          | **1,105,824.8 ns** |  **14,006.47 ns** |  **20,530.51 ns** | **1,107,945.4 ns** | **baseline** |        **** | **146.4844** | **146.4844** | **146.4844** | **1467460 B** |            **** |
| FrozenDictionary | 50000          | 4,203,024.8 ns | 115,091.63 ns | 165,060.98 ns | 4,226,236.7 ns |    +280% |    4.7% | 328.1250 | 328.1250 | 328.1250 | 3737663 B |       +155% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **60000**          | **1,588,138.0 ns** |  **28,976.32 ns** |  **41,556.97 ns** | **1,581,944.0 ns** | **baseline** |        **** | **498.0469** | **498.0469** | **498.0469** | **1760295 B** |            **** |
| FrozenDictionary | 60000          | 5,570,801.5 ns |  71,374.93 ns | 104,620.44 ns | 5,593,530.9 ns |    +251% |    3.1% | 328.1250 | 328.1250 | 328.1250 | 4485362 B |       +155% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **70000**          | **1,805,048.8 ns** |  **51,186.06 ns** |  **75,027.86 ns** | **1,822,956.6 ns** | **baseline** |        **** | **185.5469** | **185.5469** | **185.5469** | **2113651 B** |            **** |
| FrozenDictionary | 70000          | 6,144,284.2 ns | 102,687.85 ns | 153,698.34 ns | 6,168,560.5 ns |    +241% |    5.4% | 375.0000 | 375.0000 | 375.0000 | 5326809 B |       +152% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **80000**          | **1,946,470.4 ns** |  **28,180.29 ns** |  **42,178.93 ns** | **1,949,777.1 ns** | **baseline** |        **** | **181.6406** | **181.6406** | **181.6406** | **2536230 B** |            **** |
| FrozenDictionary | 80000          | 7,057,093.0 ns | 161,732.66 ns | 237,065.64 ns | 7,064,384.4 ns |    +263% |    4.2% | 375.0000 | 375.0000 | 375.0000 | 6279731 B |       +148% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **90000**          | **2,281,101.8 ns** |  **69,411.97 ns** | **103,892.57 ns** | **2,282,299.2 ns** | **baseline** |        **** | **171.8750** | **171.8750** | **171.8750** | **2536087 B** |            **** |
| FrozenDictionary | 90000          | 7,948,613.1 ns | 323,225.96 ns | 483,789.40 ns | 8,040,079.7 ns |    +249% |    7.0% | 375.0000 | 375.0000 | 375.0000 | 6558906 B |       +159% |
|                  |                |                |               |               |                |          |         |          |          |          |           |             |
| **Dictionary**       | **100000**         | **2,596,653.2 ns** |  **73,724.81 ns** | **110,347.83 ns** | **2,578,011.7 ns** | **baseline** |        **** | **183.5938** | **183.5938** | **183.5938** | **3043208 B** |            **** |
| FrozenDictionary | 100000         | 8,154,091.8 ns | 374,573.26 ns | 560,643.62 ns | 8,208,520.3 ns |    +215% |    7.9% | 406.2500 | 406.2500 | 406.2500 | 7647608 B |       +151% |