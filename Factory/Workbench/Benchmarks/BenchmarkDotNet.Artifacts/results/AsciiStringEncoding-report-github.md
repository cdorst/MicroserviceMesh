``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Job-BUFUIW : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

LaunchCount=10  

```
|                         Method |        Mean |     Error |     StdDev |      Median | Rank |  Gen 0 | Allocated |
|------------------------------- |------------:|----------:|-----------:|------------:|-----:|-------:|----------:|
|   AsciiEncoding_StringLength12 |    43.00 ns | 0.0883 ns |  0.3198 ns |    42.93 ns |    1 | 0.0127 |      40 B |
|  AsciiEncoding_StringLength900 | 1,458.92 ns | 2.3826 ns |  8.5403 ns | 1,456.77 ns |    5 | 0.2937 |     928 B |
| AsciiEncoding_StringLength2500 | 4,003.89 ns | 8.1383 ns | 28.9610 ns | 3,996.41 ns |    6 | 0.8011 |    2536 B |
|    UTF8Encoding_StringLength12 |    46.96 ns | 0.0817 ns |  0.2918 ns |    46.89 ns |    2 | 0.0127 |      40 B |
|   UTF8Encoding_StringLength900 |   531.09 ns | 1.1478 ns |  4.1290 ns |   530.35 ns |    3 | 0.2947 |     928 B |
|  UTF8Encoding_StringLength2500 | 1,358.26 ns | 2.5586 ns |  9.1381 ns | 1,356.61 ns |    4 | 0.8049 |    2536 B |
