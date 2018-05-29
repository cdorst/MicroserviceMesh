namespace Shared.Elements
{
    public interface IDatum<TElement, TKey, TValue> : IElement<TElement, TKey> 
        where TKey : unmanaged
        where TElement : IElement<TElement, TKey>
    {
        TValue Value { get; }
    }
}
