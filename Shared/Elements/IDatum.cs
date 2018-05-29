namespace Shared.Elements
{
    public interface IDatum<TKey, TValue> : IElement<TKey> 
        where TKey : unmanaged
    {
        TValue Value { get; }
    }
}
