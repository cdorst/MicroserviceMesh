namespace Benchmarks.Experiments.InRefConstructorOverloadLayerTypes.WithoutInKeyword
{
    public abstract class KeyedEntity
    {
        public KeyedEntity(byte? keySize = default)
            => KeySize = keySize;

        public byte? KeySize { get; set; }
    }
}
