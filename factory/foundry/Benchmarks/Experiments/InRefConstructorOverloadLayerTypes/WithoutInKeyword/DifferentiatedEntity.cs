namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithoutInKeyword
{
    public abstract class DifferentiatedEntity : NamedTypedKeyedEntity
    {
        public DifferentiatedEntity(string type,
            string block = default,
            string layer = default,
            string @namespace = default,
            byte? keySize = default)
            : base(type, @namespace, keySize)
        {
            BlockName = block;
            LayerName = layer;
        }

        public string BlockName { get; set; }
        public string LayerName { get; set; }
    }
}
