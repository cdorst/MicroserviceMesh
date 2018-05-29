namespace Shared.Elements
{
    public interface IElement<TKey> where TKey : unmanaged
    {
        TKey Id { get; }
    }
}
