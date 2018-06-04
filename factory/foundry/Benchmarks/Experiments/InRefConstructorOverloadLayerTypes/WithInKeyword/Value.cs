namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithInKeyword
{
    public class Value : NamedTypedKeyedEntity
    {
        public Value(in string type, in string @namespace = default)
            : base(in type, in @namespace)
        {
        }
    }
}
