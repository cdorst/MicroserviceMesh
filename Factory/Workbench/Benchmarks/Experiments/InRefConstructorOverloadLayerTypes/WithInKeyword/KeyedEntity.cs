namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithInKeyword
{
    public abstract class KeyedEntity
    {
        public KeyedEntity(in byte? keySize = default)
            => KeySize = keySize;

        public byte? KeySize { get; set; }
    }
}
