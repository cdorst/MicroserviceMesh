using System;

namespace Shared.Entities
{
    public interface IHierarchyAttributable<TEntity, TKey, TFlags>
        where TKey : unmanaged, IEquatable<TKey>
        where TEntity : IHierarchy<TEntity, TKey>
        where TFlags : Enum
    {
        Enum AttributeFlags { get; }
    }
}
