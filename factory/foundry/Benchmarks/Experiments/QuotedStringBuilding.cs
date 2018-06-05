using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Jobs;
using System.Text;
using static System.String;

namespace Benchmarks.Experiments
{
    [SimpleJob(10)]
    [MemoryDiagnoser]
    [RankColumn]
    public class QuotedStringBuilding
    {
        private const string Quote = "\"";
        private const string Value1 = nameof(Value1);
        private const string Value2 = nameof(Value2);

        [Benchmark]
        public string UsingOnlyStringBuilder()
            => new StringBuilder().Append(Quote).Append(Value1).Append(Quote).Append(Value2).ToString();

        [Benchmark]
        public string UsingStringBuilderAndConcat()
            => new StringBuilder().Append(Concat(Quote, Value1, Quote)).Append(Value2).ToString();
    }
}
