using System;

namespace Shared.Elements
{
    public interface IPermissionDelete<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        where TElement : IPermissionDelete<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermissionDelete<TElement, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TElement, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TElement : IPermissionDelete<TElement, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
        where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermissionDelete<TElement, TKey, THierarchy, THierarchyKey>
        : IPermission<TElement, TKey, THierarchy, THierarchyKey>
        where TElement : IPermissionDelete<TElement, TKey, THierarchy, THierarchyKey>
        where TKey : unmanaged, IEquatable<TKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where THierarchy : IHierarchy<THierarchy, THierarchyKey>
    {
    }
}
