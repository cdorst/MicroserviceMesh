namespace Shared
{
    public interface IElement<TKey> where TKey : unmanaged
    {
        TKey Id { get; }
    }
}
