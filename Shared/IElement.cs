using System;

namespace Shared
{
    public interface IElement<TElement, TKey> : IEquatable<TElement>, IMemorySerializable
        where TKey : unmanaged
        where TElement : IElement<TElement, TKey>
    {
        TKey Id { get; }
    }
}
