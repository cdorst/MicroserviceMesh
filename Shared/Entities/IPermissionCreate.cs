using System;

namespace Shared.Entities
{
    public interface IPermissionCreate<TEntity, TKey, TDatum, TDatumKey, TDatumValue> 
        : IPermission<TEntity, TKey>
        where TEntity : IPermissionCreate<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermissionCreate<TEntity, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TEntity, TKey>
        where TEntity : IPermissionCreate<TEntity, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
        where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermissionCreate<TEntity, TKey, THierarchy, THierarchyKey>
        : IPermission<TEntity, TKey>
        where TEntity : IPermissionCreate<TEntity, TKey, THierarchy, THierarchyKey>
        where TKey : unmanaged, IEquatable<TKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where THierarchy : IHierarchy<THierarchy, THierarchyKey>
    {
    }
}
