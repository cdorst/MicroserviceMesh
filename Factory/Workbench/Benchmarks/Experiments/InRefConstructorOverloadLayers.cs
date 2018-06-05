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
            public static readonly string Block = nameof(Block);
            public static readonly string Layer = nameof(Layer);
            public static readonly string Type = nameof(Type);
            public static readonly string ValueNamespace = nameof(ValueNamespace);
            public static readonly string ValueType = nameof(ValueType);
        }

        [Benchmark]
        public WithInKeyword WithInKeyword() => new WithInKeyword(Constants.Block, Constants.Layer, Constants.Type, Constants.ValueType, Constants.ValueNamespace);

        [Benchmark]
        public WithInKeyword WithInKeyword_InRefInvocation() => new WithInKeyword(in Constants.Block, in Constants.Layer, in Constants.Type, in Constants.ValueType, in Constants.ValueNamespace);

        [Benchmark]
        public WithoutInKeyword WithoutInKeyword() => new WithoutInKeyword(Constants.Block, Constants.Layer, Constants.Type, Constants.ValueType, Constants.ValueNamespace);
    }
}
