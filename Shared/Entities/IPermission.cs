using Shared.Entities.Primitives;
using System;

namespace Shared.Entities
{
    public interface IPermission<TEntity, TKey>
        : IHierarchy<TEntity, TKey, AgentIdentifier, long, Uuid, long, Guid>
        where TKey : unmanaged, IEquatable<TKey>
        where TEntity : IPermission<TEntity, TKey>
    {
    }

    public interface IPermission<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TEntity, TKey>,
            IHierarchy<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        where TEntity : IPermission<TEntity, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermission<TEntity, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TEntity, TKey>,
            IHierarchy<TEntity, TKey, AgentIdentifier, long, Uuid, long, Guid, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TEntity : IPermission<TEntity, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
        where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermission<TEntity, TKey, THierarchy, THierarchyKey>
        : IPermission<TEntity, TKey>,
            IHierarchy<TEntity, TKey, AgentIdentifier, long, Uuid, long, Guid, THierarchy, THierarchyKey>
        where TEntity : IPermission<TEntity, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where THierarchy : IHierarchy<THierarchy, THierarchyKey>
    {
    }
}
