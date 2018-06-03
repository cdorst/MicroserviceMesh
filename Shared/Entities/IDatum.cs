using System;

namespace Shared.Entities
{
    public interface IDatum<TEntity, TKey, TValue> : IEntity<TEntity, TKey> 
        where TKey : unmanaged, IEquatable<TKey>
        where TEntity : IEntity<TEntity, TKey>
    {
        TValue Value { get; }
    }
}
