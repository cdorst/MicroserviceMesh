namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithoutInKeyword
{
    public abstract class NamedTypedKeyedEntity : KeyedEntity
    {
        public NamedTypedKeyedEntity(string type,
            string @namespace = default,
            byte? keySize = default)
            : base(keySize)
        {
            Namespace = @namespace;
            Type = type;
        }

        public string Namespace { get; set; }
        public string Type { get; set; }
    }
}
