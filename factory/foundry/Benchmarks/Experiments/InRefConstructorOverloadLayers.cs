using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using WithInKeyword = Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithInKeyword.Entity;
using WithoutInKeyword = Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithoutInKeyword.Entity;

namespace Benchmarks.Experiments
{
    [SimpleJob(10), MemoryDiagnoser]
    [RPlotExporter, RankColumn]
    public class InRefConstructorOverloadLayers
    {
        private static class Constants
        {
            public const int Iterations = 1000;

            public static readonly string Block = nameof(Block);
            public static readonly string Layer = nameof(Layer);
            public static readonly string Type = nameof(Type);
            public static readonly string ValueNamespace = nameof(ValueNamespace);
            public static readonly string ValueType = nameof(ValueType);
        }

        [Benchmark]
        public void WithInKeyword()
        {
            for (int i = 0; i < Constants.Iterations; i++)
                new WithInKeyword(Constants.Block, Constants.Layer, Constants.Type, Constants.ValueType, Constants.ValueNamespace);
        }

        [Benchmark]
        public void WithInKeyword_InRefInvocation()
        {
            for (int i = 0; i < Constants.Iterations; i++)
                new WithInKeyword(in Constants.Block, in Constants.Layer, in Constants.Type, in Constants.ValueType, in Constants.ValueNamespace);
        }

        [Benchmark]
        public void WithoutInKeyword()
        {
            for (int i = 0; i < Constants.Iterations; i++)
                new WithoutInKeyword(Constants.Block, Constants.Layer, Constants.Type, Constants.ValueType, Constants.ValueNamespace);
        }
    }
}
