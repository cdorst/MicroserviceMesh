namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithInKeyword
{
    public abstract class DifferentiatedEntity : NamedTypedKeyedEntity
    {
        public DifferentiatedEntity(in string type,
            in string block = default,
            in string layer = default,
            in string @namespace = default,
            in byte? keySize = default)
            : base(in type, in @namespace, in keySize)
        {
            BlockName = block;
            LayerName = layer;
        }

        public string BlockName { get; set; }
        public string LayerName { get; set; }
    }
}
