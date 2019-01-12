# AlaFibonacci
Test console application, which calculates a la Fibonacci sequence.

Consists of four parts.

## AlaFibonacci
Main console application, which provides bridge between user and application below.
## AlaFibonacci.Core
Provides `AlaFibonacciCalculator` - static class, which calculates, corresponding to index, AlaFibonacci sequence member.
### A few notes about implementation
So, the main question is - why did you choose static class and static method as well?

The answer is simple. Because static is the simplest way.

Of course we can use _Strategy_ pattern, create `AlaFibonacciSequence` which is _Façade_ and sort of _Context_ for all manipulations with that sequence, create a bunch of strategies e.g. `SimpleAlaFibonacciCalculator`, `DynamicAlaFibonacciCalculator`, `MatrixAlaFibonacciCalculator`, and finally inject that with the help of _Dependency Injection_ container. `AlaFibonacci` enterprise edition as it is.
## AlaFibonacci.Tests
Simple unit tests of `AlaFibonacciCalculator`.
## AlaFibonacci.Benchmarks
Benchmark, which measures performance of `AlaFibonacciCalculator`.
### Example of benchmark result
``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.523 (1803/April2018Update/Redstone4)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.200-preview-009648
  [Host]     : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT


```
|    Method |  Index |              Mean |             Error |             StdDev |            Median |
|---------- |------- |------------------:|------------------:|-------------------:|------------------:|
| **Calculate** |      **0** |          **16.45 ns** |          **1.324 ns** |           **3.904 ns** |          **15.72 ns** |
| **Calculate** |      **1** |          **20.29 ns** |          **1.742 ns** |           **5.136 ns** |          **19.26 ns** |
| **Calculate** |      **5** |         **218.81 ns** |          **6.937 ns** |          **20.453 ns** |         **221.45 ns** |
| **Calculate** |     **10** |         **553.30 ns** |         **15.741 ns** |          **46.413 ns** |         **567.05 ns** |
| **Calculate** |     **25** |       **1,441.65 ns** |         **62.309 ns** |         **183.721 ns** |       **1,415.30 ns** |
| **Calculate** |     **50** |       **4,230.62 ns** |        **196.823 ns** |         **548.663 ns** |       **4,144.93 ns** |
| **Calculate** |    **100** |      **14,020.65 ns** |        **573.617 ns** |       **1,691.323 ns** |      **14,388.42 ns** |
| **Calculate** |    **250** |      **45,312.07 ns** |      **2,156.689 ns** |       **6,291.162 ns** |      **45,845.47 ns** |
| **Calculate** |    **500** |     **106,155.42 ns** |      **5,179.879 ns** |      **15,272.990 ns** |     **107,881.78 ns** |
| **Calculate** |   **1000** |     **285,771.08 ns** |     **24,300.359 ns** |      **71,650.157 ns** |     **273,259.23 ns** |
| **Calculate** |   **2500** |     **844,685.76 ns** |     **35,907.103 ns** |     **103,024.208 ns** |     **851,902.04 ns** |
| **Calculate** |   **5000** |   **2,610,337.28 ns** |    **140,376.456 ns** |     **411,699.845 ns** |   **2,620,543.63 ns** |
| **Calculate** |  **10000** |   **8,590,966.25 ns** |    **378,129.404 ns** |   **1,114,923.079 ns** |   **8,653,526.80 ns** |
| **Calculate** |  **25000** |  **45,297,977.70 ns** |  **2,399,107.524 ns** |   **7,036,167.067 ns** |  **45,661,123.08 ns** |
| **Calculate** |  **50000** | **174,762,020.75 ns** |  **9,129,784.471 ns** |  **26,632,009.832 ns** | **174,858,333.33 ns** |
| **Calculate** | **100000** | **691,708,238.20 ns** | **37,321,593.001 ns** | **103,417,958.413 ns** | **685,595,900.00 ns** |
