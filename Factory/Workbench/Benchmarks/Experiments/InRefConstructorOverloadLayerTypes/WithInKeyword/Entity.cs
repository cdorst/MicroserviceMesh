namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithInKeyword
{
    public class Entity : DifferentiatedEntity
    {
        public Entity(in string block, in string layer, in string type, in Value value)
            : base(in block, in layer, in type)
        {
            Value = value;
        }
        public Entity(in string block, in string layer, in string type, in string valueType, in string valueNamespace = default)
            : this(in block, in layer, in type, new Value(in valueType, in valueNamespace))
        {
        }

        public Value Value { get; set; }
    }
}
