``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Job-YYDXKX : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

LaunchCount=10  

```
|                        Method |     Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|------------------------------ |---------:|----------:|----------:|-----:|-------:|----------:|
|                 WithInKeyword | 23.82 ns | 0.0684 ns | 0.2380 ns |    1 | 0.0331 |     104 B |
| WithInKeyword_InRefInvocation | 24.02 ns | 0.0965 ns | 0.3395 ns |    2 | 0.0331 |     104 B |
|              WithoutInKeyword | 24.01 ns | 0.0594 ns | 0.2075 ns |    2 | 0.0331 |     104 B |
