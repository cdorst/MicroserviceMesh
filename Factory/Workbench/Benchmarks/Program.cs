using static BenchmarkDotNet.Running.BenchmarkRunner;

namespace Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Run<Experiments.InRefConstructorOverloadLayers>();
            Run<Experiments.QuotedStringBuilding>();
        }
    }
}
