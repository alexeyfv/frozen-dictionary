```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.4037/23H2/2023Update/SunValley3)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.203
  [Host]     : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  Job-FBWGLX : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

IterationCount=30  

```
| Method           | DictionarySize | Mean            | Error         | StdDev        | Ratio    | RatioSD |
|----------------- |--------------- |----------------:|--------------:|--------------:|---------:|--------:|
| **Dictionary**       | **11**             |        **65.90 ns** |      **1.256 ns** |      **1.880 ns** | **baseline** |        **** |
| FrozenDictionary | 11             |        41.57 ns |      0.682 ns |      1.020 ns |     -37% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **20**             |       **126.14 ns** |      **2.849 ns** |      **4.264 ns** | **baseline** |        **** |
| FrozenDictionary | 20             |        79.30 ns |      1.733 ns |      2.594 ns |     -37% |    4.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **29**             |       **181.30 ns** |      **3.677 ns** |      **5.504 ns** | **baseline** |        **** |
| FrozenDictionary | 29             |       112.72 ns |      2.278 ns |      3.409 ns |     -38% |    4.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **38**             |       **230.53 ns** |      **4.001 ns** |      **5.989 ns** | **baseline** |        **** |
| FrozenDictionary | 38             |       144.22 ns |      3.476 ns |      5.203 ns |     -37% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **47**             |       **283.38 ns** |      **5.580 ns** |      **8.352 ns** | **baseline** |        **** |
| FrozenDictionary | 47             |       177.19 ns |      3.897 ns |      5.833 ns |     -37% |    4.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **56**             |       **342.34 ns** |      **6.679 ns** |      **9.997 ns** | **baseline** |        **** |
| FrozenDictionary | 56             |       207.01 ns |      3.864 ns |      5.663 ns |     -40% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **65**             |       **395.03 ns** |      **7.764 ns** |     **11.621 ns** | **baseline** |        **** |
| FrozenDictionary | 65             |       242.96 ns |      4.124 ns |      6.172 ns |     -38% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **74**             |       **442.58 ns** |      **8.485 ns** |     **12.437 ns** | **baseline** |        **** |
| FrozenDictionary | 74             |       275.77 ns |      5.471 ns |      8.188 ns |     -38% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **83**             |       **497.40 ns** |      **6.104 ns** |      **8.556 ns** | **baseline** |        **** |
| FrozenDictionary | 83             |       308.46 ns |      4.951 ns |      7.411 ns |     -38% |    2.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **92**             |       **549.07 ns** |     **10.707 ns** |     **15.694 ns** | **baseline** |        **** |
| FrozenDictionary | 92             |       342.73 ns |      6.615 ns |      9.902 ns |     -38% |    3.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **100**            |       **614.62 ns** |     **13.899 ns** |     **20.803 ns** | **baseline** |        **** |
| FrozenDictionary | 100            |       367.85 ns |      6.075 ns |      9.093 ns |     -40% |    3.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **136**            |       **817.68 ns** |     **10.159 ns** |     **15.206 ns** | **baseline** |        **** |
| FrozenDictionary | 136            |       497.11 ns |      9.276 ns |     13.883 ns |     -39% |    2.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **172**            |     **1,039.65 ns** |     **16.860 ns** |     **25.235 ns** | **baseline** |        **** |
| FrozenDictionary | 172            |       622.80 ns |     17.115 ns |     25.616 ns |     -40% |    4.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **208**            |     **1,244.72 ns** |     **25.162 ns** |     **36.882 ns** | **baseline** |        **** |
| FrozenDictionary | 208            |       748.78 ns |     14.478 ns |     21.671 ns |     -40% |    4.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **244**            |     **1,464.29 ns** |     **25.500 ns** |     **37.377 ns** | **baseline** |        **** |
| FrozenDictionary | 244            |       875.98 ns |     15.393 ns |     22.563 ns |     -40% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **280**            |     **1,657.89 ns** |     **30.502 ns** |     **45.653 ns** | **baseline** |        **** |
| FrozenDictionary | 280            |     1,021.52 ns |     16.735 ns |     24.530 ns |     -38% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **316**            |     **1,850.16 ns** |     **38.812 ns** |     **58.092 ns** | **baseline** |        **** |
| FrozenDictionary | 316            |     1,149.82 ns |     22.599 ns |     33.825 ns |     -38% |    4.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **352**            |     **2,087.08 ns** |     **36.724 ns** |     **54.967 ns** | **baseline** |        **** |
| FrozenDictionary | 352            |     1,276.65 ns |     28.843 ns |     43.171 ns |     -39% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **388**            |     **2,304.34 ns** |     **52.546 ns** |     **78.648 ns** | **baseline** |        **** |
| FrozenDictionary | 388            |     1,414.29 ns |     31.690 ns |     47.431 ns |     -39% |    4.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **424**            |     **2,541.41 ns** |     **49.605 ns** |     **74.246 ns** | **baseline** |        **** |
| FrozenDictionary | 424            |     1,546.51 ns |     27.415 ns |     41.033 ns |     -39% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **460**            |     **2,768.02 ns** |     **42.634 ns** |     **63.812 ns** | **baseline** |        **** |
| FrozenDictionary | 460            |     1,664.20 ns |     26.908 ns |     40.274 ns |     -40% |    3.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **496**            |     **2,954.47 ns** |     **66.047 ns** |     **98.856 ns** | **baseline** |        **** |
| FrozenDictionary | 496            |     1,793.59 ns |     32.154 ns |     48.127 ns |     -39% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **532**            |     **3,194.84 ns** |     **52.104 ns** |     **77.987 ns** | **baseline** |        **** |
| FrozenDictionary | 532            |     1,901.41 ns |     34.744 ns |     52.003 ns |     -40% |    3.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **568**            |     **3,375.35 ns** |     **62.555 ns** |     **93.629 ns** | **baseline** |        **** |
| FrozenDictionary | 568            |     2,057.02 ns |     31.427 ns |     47.038 ns |     -39% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **604**            |     **3,590.77 ns** |     **72.762 ns** |    **108.907 ns** | **baseline** |        **** |
| FrozenDictionary | 604            |     2,233.75 ns |     62.978 ns |     94.263 ns |     -38% |    4.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **640**            |     **3,993.73 ns** |     **73.862 ns** |    **103.544 ns** | **baseline** |        **** |
| FrozenDictionary | 640            |     2,328.77 ns |     49.474 ns |     74.050 ns |     -42% |    4.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **676**            |     **3,994.71 ns** |     **77.035 ns** |    **115.303 ns** | **baseline** |        **** |
| FrozenDictionary | 676            |     2,447.82 ns |     46.306 ns |     67.875 ns |     -39% |    4.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **712**            |     **4,257.26 ns** |     **91.725 ns** |    **137.290 ns** | **baseline** |        **** |
| FrozenDictionary | 712            |     2,596.37 ns |     48.373 ns |     72.403 ns |     -39% |    4.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **748**            |     **4,465.80 ns** |     **71.658 ns** |    **105.035 ns** | **baseline** |        **** |
| FrozenDictionary | 748            |     2,759.41 ns |     54.502 ns |     81.577 ns |     -38% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **784**            |     **4,681.51 ns** |     **91.048 ns** |    **136.277 ns** | **baseline** |        **** |
| FrozenDictionary | 784            |     2,874.31 ns |     51.714 ns |     77.402 ns |     -39% |    4.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **820**            |     **4,876.06 ns** |     **99.182 ns** |    **148.450 ns** | **baseline** |        **** |
| FrozenDictionary | 820            |     3,001.23 ns |     44.061 ns |     65.949 ns |     -38% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **856**            |     **5,150.00 ns** |    **124.040 ns** |    **185.657 ns** | **baseline** |        **** |
| FrozenDictionary | 856            |     3,113.31 ns |     53.154 ns |     79.558 ns |     -39% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **892**            |     **5,318.23 ns** |    **103.625 ns** |    **155.101 ns** | **baseline** |        **** |
| FrozenDictionary | 892            |     3,242.68 ns |     53.802 ns |     80.529 ns |     -39% |    3.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **928**            |     **5,535.29 ns** |    **106.318 ns** |    **159.132 ns** | **baseline** |        **** |
| FrozenDictionary | 928            |     3,386.36 ns |     53.953 ns |     79.083 ns |     -39% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **964**            |     **5,806.50 ns** |     **97.648 ns** |    **146.155 ns** | **baseline** |        **** |
| FrozenDictionary | 964            |     3,502.15 ns |     71.685 ns |    107.295 ns |     -40% |    4.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **1000**           |     **5,993.81 ns** |    **104.879 ns** |    **156.978 ns** | **baseline** |        **** |
| FrozenDictionary | 1000           |     3,600.13 ns |     55.843 ns |     83.583 ns |     -40% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **1360**           |     **8,249.56 ns** |    **182.070 ns** |    **272.513 ns** | **baseline** |        **** |
| FrozenDictionary | 1360           |     4,944.47 ns |    103.372 ns |    154.722 ns |     -40% |    4.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **1720**           |    **10,302.88 ns** |    **231.954 ns** |    **347.178 ns** | **baseline** |        **** |
| FrozenDictionary | 1720           |     6,241.22 ns |    110.007 ns |    164.653 ns |     -39% |    4.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **2080**           |    **12,414.93 ns** |    **266.615 ns** |    **399.056 ns** | **baseline** |        **** |
| FrozenDictionary | 2080           |     7,497.81 ns |     91.783 ns |    134.535 ns |     -39% |    3.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **2440**           |    **14,507.51 ns** |    **208.943 ns** |    **312.736 ns** | **baseline** |        **** |
| FrozenDictionary | 2440           |     8,783.03 ns |    208.048 ns |    304.954 ns |     -39% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **2800**           |    **16,694.11 ns** |    **333.049 ns** |    **498.492 ns** | **baseline** |        **** |
| FrozenDictionary | 2800           |    10,119.95 ns |    213.726 ns |    319.895 ns |     -39% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **3160**           |    **18,645.68 ns** |    **446.032 ns** |    **667.599 ns** | **baseline** |        **** |
| FrozenDictionary | 3160           |    11,450.76 ns |    215.597 ns |    322.696 ns |     -39% |    4.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **3520**           |    **20,997.54 ns** |    **486.910 ns** |    **728.784 ns** | **baseline** |        **** |
| FrozenDictionary | 3520           |    12,756.81 ns |    183.169 ns |    274.159 ns |     -39% |    4.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **3880**           |    **23,385.56 ns** |    **407.983 ns** |    **610.650 ns** | **baseline** |        **** |
| FrozenDictionary | 3880           |    13,957.28 ns |    227.414 ns |    326.150 ns |     -40% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **4240**           |    **25,306.85 ns** |    **396.339 ns** |    **593.222 ns** | **baseline** |        **** |
| FrozenDictionary | 4240           |    15,244.09 ns |    180.185 ns |    269.693 ns |     -40% |    2.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **4600**           |    **27,532.49 ns** |    **349.902 ns** |    **523.717 ns** | **baseline** |        **** |
| FrozenDictionary | 4600           |    16,704.91 ns |    323.732 ns |    484.547 ns |     -39% |    3.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **4960**           |    **29,536.77 ns** |    **516.396 ns** |    **772.917 ns** | **baseline** |        **** |
| FrozenDictionary | 4960           |    18,014.19 ns |    360.463 ns |    539.525 ns |     -39% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **5320**           |    **31,833.30 ns** |    **537.296 ns** |    **804.200 ns** | **baseline** |        **** |
| FrozenDictionary | 5320           |    19,192.62 ns |    345.237 ns |    516.735 ns |     -40% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **5680**           |    **33,528.07 ns** |    **727.305 ns** |  **1,088.596 ns** | **baseline** |        **** |
| FrozenDictionary | 5680           |    20,615.26 ns |    429.908 ns |    643.466 ns |     -38% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **6040**           |    **35,783.05 ns** |    **788.573 ns** |  **1,180.299 ns** | **baseline** |        **** |
| FrozenDictionary | 6040           |    22,072.03 ns |    369.367 ns |    552.851 ns |     -38% |    4.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **6400**           |    **38,220.26 ns** |    **777.596 ns** |  **1,163.868 ns** | **baseline** |        **** |
| FrozenDictionary | 6400           |    23,159.31 ns |    507.386 ns |    759.432 ns |     -39% |    3.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **6760**           |    **40,611.89 ns** |    **767.857 ns** |  **1,149.293 ns** | **baseline** |        **** |
| FrozenDictionary | 6760           |    24,645.02 ns |    441.565 ns |    660.914 ns |     -39% |    4.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **7120**           |    **42,640.44 ns** |    **738.459 ns** |  **1,105.290 ns** | **baseline** |        **** |
| FrozenDictionary | 7120           |    25,777.27 ns |    485.329 ns |    726.418 ns |     -40% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **7480**           |    **44,991.62 ns** |    **750.249 ns** |  **1,122.938 ns** | **baseline** |        **** |
| FrozenDictionary | 7480           |    26,958.63 ns |    376.250 ns |    527.450 ns |     -40% |    3.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **7840**           |    **46,972.30 ns** |    **787.851 ns** |  **1,179.219 ns** | **baseline** |        **** |
| FrozenDictionary | 7840           |    28,340.37 ns |    451.084 ns |    675.161 ns |     -40% |    3.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **8200**           |    **48,492.05 ns** |    **979.765 ns** |  **1,466.466 ns** | **baseline** |        **** |
| FrozenDictionary | 8200           |    29,835.48 ns |    413.574 ns |    606.212 ns |     -38% |    3.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **8560**           |    **50,905.60 ns** |    **957.626 ns** |  **1,433.330 ns** | **baseline** |        **** |
| FrozenDictionary | 8560           |    31,086.29 ns |    622.256 ns |    931.363 ns |     -39% |    4.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **8920**           |    **53,137.11 ns** |    **722.229 ns** |  **1,080.998 ns** | **baseline** |        **** |
| FrozenDictionary | 8920           |    32,960.30 ns |    673.214 ns |    986.788 ns |     -38% |    3.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **9280**           |    **55,417.16 ns** |    **761.759 ns** |  **1,140.165 ns** | **baseline** |        **** |
| FrozenDictionary | 9280           |    33,893.00 ns |    753.247 ns |  1,104.099 ns |     -39% |    3.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **9640**           |    **57,129.75 ns** |  **1,158.935 ns** |  **1,734.639 ns** | **baseline** |        **** |
| FrozenDictionary | 9640           |    35,150.54 ns |    747.578 ns |  1,118.939 ns |     -38% |    3.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **10000**          |    **59,813.68 ns** |    **921.026 ns** |  **1,378.549 ns** | **baseline** |        **** |
| FrozenDictionary | 10000          |    36,572.60 ns |    804.669 ns |  1,204.391 ns |     -39% |    4.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **13600**          |    **81,350.27 ns** |  **1,748.715 ns** |  **2,617.395 ns** | **baseline** |        **** |
| FrozenDictionary | 13600          |    49,663.67 ns |  1,058.706 ns |  1,584.621 ns |     -39% |    4.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **17200**          |   **103,374.12 ns** |  **1,838.067 ns** |  **2,751.132 ns** | **baseline** |        **** |
| FrozenDictionary | 17200          |    62,953.88 ns |  1,117.466 ns |  1,672.571 ns |     -39% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **20800**          |   **126,975.84 ns** |  **1,895.467 ns** |  **2,837.046 ns** | **baseline** |        **** |
| FrozenDictionary | 20800          |    75,758.02 ns |  1,562.477 ns |  2,290.259 ns |     -40% |    4.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **24400**          |   **147,504.59 ns** |  **2,215.967 ns** |  **3,248.136 ns** | **baseline** |        **** |
| FrozenDictionary | 24400          |    90,680.54 ns |  1,409.018 ns |  2,108.951 ns |     -38% |    3.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **28000**          |   **169,420.34 ns** |  **3,369.196 ns** |  **5,042.854 ns** | **baseline** |        **** |
| FrozenDictionary | 28000          |   102,697.35 ns |  1,538.067 ns |  2,254.479 ns |     -39% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **31600**          |   **190,863.40 ns** |  **3,122.855 ns** |  **4,674.143 ns** | **baseline** |        **** |
| FrozenDictionary | 31600          |   115,020.56 ns |  2,173.239 ns |  3,252.802 ns |     -40% |    3.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **35200**          |   **211,461.84 ns** |  **3,721.044 ns** |  **5,569.484 ns** | **baseline** |        **** |
| FrozenDictionary | 35200          |   129,601.09 ns |  2,178.966 ns |  3,261.374 ns |     -39% |    3.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **38800**          |   **231,517.40 ns** |  **4,122.959 ns** |  **6,043.379 ns** | **baseline** |        **** |
| FrozenDictionary | 38800          |   144,345.74 ns |  1,722.656 ns |  2,578.390 ns |     -38% |    3.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **42400**          |   **256,059.36 ns** |  **3,699.880 ns** |  **5,423.237 ns** | **baseline** |        **** |
| FrozenDictionary | 42400          |   156,710.47 ns |  2,935.975 ns |  4,394.430 ns |     -39% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **46000**          |   **277,021.74 ns** |  **4,605.409 ns** |  **6,604.939 ns** | **baseline** |        **** |
| FrozenDictionary | 46000          |   168,121.83 ns |  2,404.139 ns |  3,447.945 ns |     -39% |    2.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **49600**          |   **298,688.01 ns** |  **5,137.050 ns** |  **7,688.895 ns** | **baseline** |        **** |
| FrozenDictionary | 49600          |   181,877.50 ns |  2,718.164 ns |  3,984.250 ns |     -39% |    3.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **53200**          |   **319,438.84 ns** |  **4,195.303 ns** |  **6,149.421 ns** | **baseline** |        **** |
| FrozenDictionary | 53200          |   197,015.33 ns |  2,808.259 ns |  4,203.269 ns |     -38% |    2.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **56800**          |   **344,340.03 ns** |  **5,658.042 ns** |  **8,468.690 ns** | **baseline** |        **** |
| FrozenDictionary | 56800          |   211,306.42 ns |  3,045.683 ns |  4,558.636 ns |     -39% |    3.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **60400**          |   **365,599.35 ns** |  **5,008.285 ns** |  **7,496.166 ns** | **baseline** |        **** |
| FrozenDictionary | 60400          |   222,524.35 ns |  3,998.880 ns |  5,735.074 ns |     -39% |    3.0% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **64000**          |   **385,723.23 ns** |  **7,388.384 ns** | **10,829.798 ns** | **baseline** |        **** |
| FrozenDictionary | 64000          |   235,247.83 ns |  3,120.141 ns |  4,670.080 ns |     -39% |    3.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **67600**          |   **409,385.99 ns** |  **5,835.806 ns** |  **8,734.759 ns** | **baseline** |        **** |
| FrozenDictionary | 67600          |   249,369.93 ns |  3,509.058 ns |  5,252.193 ns |     -39% |    3.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **71200**          |   **427,400.19 ns** |  **7,313.780 ns** | **10,946.921 ns** | **baseline** |        **** |
| FrozenDictionary | 71200          |   264,364.09 ns |  3,996.938 ns |  5,982.429 ns |     -38% |    3.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **74800**          |   **456,271.79 ns** |  **7,316.143 ns** | **10,950.458 ns** | **baseline** |        **** |
| FrozenDictionary | 74800          |   275,468.01 ns |  4,279.557 ns |  6,272.919 ns |     -40% |    3.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **78400**          |   **468,491.65 ns** |  **7,837.656 ns** | **11,488.335 ns** | **baseline** |        **** |
| FrozenDictionary | 78400          |   288,530.98 ns |  4,006.183 ns |  5,996.267 ns |     -38% |    3.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **82000**          |   **500,160.83 ns** |  **7,636.735 ns** | **11,430.305 ns** | **baseline** |        **** |
| FrozenDictionary | 82000          |   303,905.94 ns |  4,521.668 ns |  6,767.819 ns |     -39% |    3.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **85600**          |   **514,200.33 ns** |  **4,594.549 ns** |  **6,289.071 ns** | **baseline** |        **** |
| FrozenDictionary | 85600          |   314,382.99 ns |  4,598.978 ns |  6,883.533 ns |     -39% |    2.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **89200**          |   **541,110.24 ns** |  **7,468.725 ns** | **11,178.837 ns** | **baseline** |        **** |
| FrozenDictionary | 89200          |   327,131.27 ns |  4,587.157 ns |  6,430.553 ns |     -40% |    2.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **92800**          |   **560,196.27 ns** |  **4,469.552 ns** |  **5,811.680 ns** | **baseline** |        **** |
| FrozenDictionary | 92800          |   363,013.16 ns |  1,628.108 ns |  2,228.573 ns |     -35% |    1.4% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **96400**          |   **640,256.17 ns** |  **6,184.975 ns** |  **8,870.306 ns** | **baseline** |        **** |
| FrozenDictionary | 96400          |   378,104.30 ns |  1,811.886 ns |  2,598.553 ns |     -41% |    1.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **100000**         |   **663,746.84 ns** |  **4,857.039 ns** |  **7,119.384 ns** | **baseline** |        **** |
| FrozenDictionary | 100000         |   399,945.43 ns |  5,007.984 ns |  7,495.715 ns |     -40% |    2.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **136000**         |   **997,039.41 ns** |  **6,806.626 ns** |  **9,977.064 ns** | **baseline** |        **** |
| FrozenDictionary | 136000         |   644,313.93 ns | 10,345.098 ns | 15,163.710 ns |     -35% |    2.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **172000**         | **1,266,235.08 ns** | **10,822.441 ns** | **16,198.521 ns** | **baseline** |        **** |
| FrozenDictionary | 172000         |   804,927.09 ns |  6,264.239 ns |  8,983.985 ns |     -36% |    1.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **208000**         | **1,524,974.59 ns** | **11,962.274 ns** | **17,534.146 ns** | **baseline** |        **** |
| FrozenDictionary | 208000         |   993,143.03 ns |  6,474.661 ns |  9,490.474 ns |     -35% |    1.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **244000**         | **1,786,371.71 ns** | **11,528.457 ns** | **16,533.769 ns** | **baseline** |        **** |
| FrozenDictionary | 244000         | 1,169,969.08 ns | 13,647.145 ns | 18,680.367 ns |     -35% |    1.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **280000**         | **2,091,605.80 ns** | **17,893.578 ns** | **25,084.297 ns** | **baseline** |        **** |
| FrozenDictionary | 280000         | 1,337,760.82 ns | 13,974.751 ns | 20,484.009 ns |     -36% |    2.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **316000**         | **2,352,337.54 ns** | **16,147.444 ns** | **23,668.713 ns** | **baseline** |        **** |
| FrozenDictionary | 316000         | 1,510,363.31 ns | 18,358.795 ns | 25,736.466 ns |     -36% |    1.7% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **352000**         | **2,597,820.10 ns** | **15,350.117 ns** | **22,014.680 ns** | **baseline** |        **** |
| FrozenDictionary | 352000         | 1,673,986.76 ns | 17,738.367 ns | 23,680.210 ns |     -36% |    1.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **388000**         | **2,861,316.45 ns** | **19,194.662 ns** | **28,729.666 ns** | **baseline** |        **** |
| FrozenDictionary | 388000         | 1,826,584.50 ns | 14,400.075 ns | 20,652.157 ns |     -36% |    1.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **424000**         | **3,110,861.82 ns** | **19,899.438 ns** | **28,539.180 ns** | **baseline** |        **** |
| FrozenDictionary | 424000         | 2,022,033.04 ns | 15,315.794 ns | 21,965.455 ns |     -35% |    1.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **460000**         | **3,408,423.24 ns** | **38,794.665 ns** | **53,102.576 ns** | **baseline** |        **** |
| FrozenDictionary | 460000         | 2,209,949.54 ns | 37,375.701 ns | 49,895.487 ns |     -35% |    2.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **496000**         | **3,646,401.38 ns** | **24,859.149 ns** | **35,652.248 ns** | **baseline** |        **** |
| FrozenDictionary | 496000         | 2,361,967.82 ns | 18,925.253 ns | 27,142.032 ns |     -35% |    1.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **532000**         | **3,956,823.30 ns** | **25,279.300 ns** | **37,054.071 ns** | **baseline** |        **** |
| FrozenDictionary | 532000         | 2,518,486.99 ns | 28,213.455 ns | 39,551.324 ns |     -36% |    1.9% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **568000**         | **4,192,197.79 ns** | **20,298.702 ns** | **28,455.945 ns** | **baseline** |        **** |
| FrozenDictionary | 568000         | 2,723,072.76 ns | 43,660.475 ns | 61,205.889 ns |     -35% |    2.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **604000**         | **4,492,007.26 ns** | **36,252.669 ns** | **53,138.691 ns** | **baseline** |        **** |
| FrozenDictionary | 604000         | 2,851,850.01 ns | 25,705.538 ns | 36,035.574 ns |     -37% |    1.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **640000**         | **4,717,966.10 ns** | **22,107.831 ns** | **31,706.391 ns** | **baseline** |        **** |
| FrozenDictionary | 640000         | 3,021,634.67 ns | 24,318.029 ns | 32,463.870 ns |     -36% |    1.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **676000**         | **4,963,844.26 ns** | **41,726.468 ns** | **58,494.681 ns** | **baseline** |        **** |
| FrozenDictionary | 676000         | 3,175,595.66 ns | 26,694.452 ns | 39,128.381 ns |     -36% |    1.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **712000**         | **5,237,119.78 ns** | **36,087.742 ns** | **51,755.962 ns** | **baseline** |        **** |
| FrozenDictionary | 712000         | 3,327,725.56 ns | 18,970.393 ns | 26,593.842 ns |     -36% |    1.3% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **748000**         | **5,470,755.51 ns** | **37,542.805 ns** | **52,629.769 ns** | **baseline** |        **** |
| FrozenDictionary | 748000         | 3,509,018.61 ns | 35,177.795 ns | 52,652.467 ns |     -36% |    2.1% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **784000**         | **5,747,804.81 ns** | **34,564.063 ns** | **47,311.679 ns** | **baseline** |        **** |
| FrozenDictionary | 784000         | 3,638,067.27 ns | 26,689.096 ns | 39,120.531 ns |     -37% |    1.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **820000**         | **5,921,494.97 ns** | **70,524.421 ns** | **98,865.389 ns** | **baseline** |        **** |
| FrozenDictionary | 820000         | 3,902,517.94 ns | 53,038.257 ns | 74,352.229 ns |     -34% |    2.2% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **856000**         | **6,239,273.33 ns** | **22,321.781 ns** | **32,718.977 ns** | **baseline** |        **** |
| FrozenDictionary | 856000         | 4,039,121.82 ns | 38,064.279 ns | 55,794.127 ns |     -35% |    1.5% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **892000**         | **6,503,200.90 ns** | **33,592.806 ns** | **45,982.212 ns** | **baseline** |        **** |
| FrozenDictionary | 892000         | 4,220,448.20 ns | 42,662.195 ns | 58,396.494 ns |     -35% |    1.6% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **928000**         | **6,904,850.46 ns** | **57,647.133 ns** | **80,813.230 ns** | **baseline** |        **** |
| FrozenDictionary | 928000         | 4,358,212.60 ns | 40,340.995 ns | 60,380.502 ns |     -37% |    1.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **964000**         | **7,013,582.95 ns** | **40,008.491 ns** | **57,378.983 ns** | **baseline** |        **** |
| FrozenDictionary | 964000         | 4,554,265.07 ns | 50,490.683 ns | 72,412.229 ns |     -35% |    1.8% |
|                  |                |                 |               |               |          |         |
| **Dictionary**       | **1000000**        | **7,345,645.62 ns** | **48,751.749 ns** | **69,918.301 ns** | **baseline** |        **** |
| FrozenDictionary | 1000000        | 4,712,357.84 ns | 49,988.366 ns | 73,272.299 ns |     -36% |    1.7% |
