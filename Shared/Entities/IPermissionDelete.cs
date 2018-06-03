﻿using System;

namespace Shared.Entities
{
    public interface IPermissionDelete<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        where TEntity : IPermissionDelete<TEntity, TKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermissionDelete<TEntity, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TEntity, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TEntity : IPermissionDelete<TEntity, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
        where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermissionDelete<TEntity, TKey, THierarchy, THierarchyKey>
        : IPermission<TEntity, TKey, THierarchy, THierarchyKey>
        where TEntity : IPermissionDelete<TEntity, TKey, THierarchy, THierarchyKey>
        where TKey : unmanaged, IEquatable<TKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where THierarchy : IHierarchy<THierarchy, THierarchyKey>
    {
    }
}
