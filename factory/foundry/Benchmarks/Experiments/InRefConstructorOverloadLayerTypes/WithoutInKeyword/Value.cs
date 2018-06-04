namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithoutInKeyword
{
    public class Value : NamedTypedKeyedEntity
    {
        public Value(string type, string @namespace = default)
            : base(type, @namespace)
        {
        }
    }
}
