``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Job-GRYEVW : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

LaunchCount=10  

```
|                        Method |     Mean |     Error |    StdDev |   Median | Rank |   Gen 0 | Allocated |
|------------------------------ |---------:|----------:|----------:|---------:|-----:|--------:|----------:|
|                 WithInKeyword | 22.88 us | 0.0550 us | 0.1944 us | 22.84 us |    3 | 33.0505 | 101.56 KB |
| WithInKeyword_InRefInvocation | 22.79 us | 0.0339 us | 0.1225 us | 22.75 us |    2 | 33.0505 | 101.56 KB |
|              WithoutInKeyword | 22.61 us | 0.0476 us | 0.1717 us | 22.56 us |    1 | 33.0505 | 101.56 KB |
