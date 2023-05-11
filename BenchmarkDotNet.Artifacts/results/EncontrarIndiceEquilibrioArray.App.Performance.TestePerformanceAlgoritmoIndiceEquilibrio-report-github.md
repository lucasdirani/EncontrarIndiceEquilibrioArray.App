``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                              Method |      Array |          Mean |       Error |      StdDev | Rank | Allocated |
|-------------------------------------------------------------------- |----------- |--------------:|------------:|------------:|-----:|----------:|
| **MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeQuadratica** | **Int32[100]** |  **3,736.736 ns** |  **64.6036 ns** |  **86.2439 ns** |    **7** |         **-** |
|     MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeLinear | Int32[100] |    104.201 ns |   1.6216 ns |   1.7350 ns |    4 |         - |
| **MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeQuadratica** |  **Int32[10]** |     **38.492 ns** |   **0.8226 ns** |   **1.3048 ns** |    **2** |         **-** |
|     MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeLinear |  Int32[10] |      9.936 ns |   0.1200 ns |   0.1122 ns |    1 |         - |
| **MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeQuadratica** | **Int32[500]** | **16,460.905 ns** | **217.8344 ns** | **181.9016 ns** |    **8** |         **-** |
|     MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeLinear | Int32[500] |    475.159 ns |   9.5126 ns |  17.8669 ns |    5 |         - |
| **MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeQuadratica** |  **Int32[50]** |    **854.111 ns** |  **15.7148 ns** |  **22.0300 ns** |    **6** |         **-** |
|     MedirPerformanceEncontrarIndiceDeEquilibrioEmComplexidadeLinear |  Int32[50] |     43.118 ns |   0.8895 ns |   1.4108 ns |    3 |         - |
