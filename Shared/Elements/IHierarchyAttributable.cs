using System;

namespace Shared.Elements
{
    public interface IHierarchyAttributable<TElement, TKey, TFlags>
        where TKey : unmanaged, IEquatable<TKey>
        where TElement : IHierarchy<TElement, TKey>
        where TFlags : Enum
    {
        Enum AttributeFlags { get; }
    }
}
