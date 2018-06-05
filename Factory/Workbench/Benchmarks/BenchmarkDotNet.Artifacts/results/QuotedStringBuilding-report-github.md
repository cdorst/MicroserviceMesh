``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Job-CJOSRU : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

LaunchCount=10  

```
|                      Method |     Mean |     Error |    StdDev |   Median | Rank |  Gen 0 | Allocated |
|---------------------------- |---------:|----------:|----------:|---------:|-----:|-------:|----------:|
|      UsingOnlyStringBuilder | 42.81 ns | 0.1041 ns | 0.3664 ns | 42.77 ns |    1 | 0.0508 |     160 B |
| UsingStringBuilderAndConcat | 61.92 ns | 0.1091 ns | 0.3853 ns | 61.82 ns |    2 | 0.0660 |     208 B |
