namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithoutInKeyword
{
    public class Entity : DifferentiatedEntity
    {
        private Entity(string block, string layer, string type, Value value)
            : base(block, layer, type)
        {
            Value = value;
        }
        public Entity(string block, string layer, string type, string valueType, string valueNamespace = default)
            : this(block, layer, type, new Value(valueType, valueNamespace))
        {
        }

        public Value Value { get; set; }
    }
}
