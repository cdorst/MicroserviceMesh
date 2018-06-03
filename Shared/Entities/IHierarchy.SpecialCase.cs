using Shared.Entities.Primitives;
using System;

namespace Shared.Entities
{
    /// <summary>Use for datum permissions</summary>
    public interface IHierarchy<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        : IHierarchy<TEntity, TKey, AgentIdentifier, long, Uuid, long, Guid>,
            IDatumLabel<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TEntity : IPermission<TEntity, TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }
}
