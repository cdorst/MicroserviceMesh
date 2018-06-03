using System;

namespace Shared
{
    public interface IEntity<TEntity, TKey> : IEquatable<TEntity>, IMemorySerializable
        where TKey : unmanaged, IEquatable<TKey>
        where TEntity : IEntity<TEntity, TKey>
    {
        TKey Id { get; }
    }
}
