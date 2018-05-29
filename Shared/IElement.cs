namespace Shared
{
    public interface IElement<TKey> : IMemorySerializable
        where TKey : unmanaged
    {
        TKey Id { get; }
    }
}
