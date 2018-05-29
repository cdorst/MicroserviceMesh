using Shared.Elements.Primitives;
using System;

namespace Shared.Elements
{
    public interface IPermission<TElement, TKey>
        : IHierarchy<TElement, TKey, AgentIdentifier, long, Uuid, long, Guid>
        where TKey : unmanaged, IEquatable<TKey>
        where TElement : IPermission<TElement, TKey>
    {
    }

    public interface IPermission<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TElement, TKey>,
            IHierarchy<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        where TElement : IPermission<TElement, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermission<TElement, TKey, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        : IPermission<TElement, TKey>,
            IHierarchy<TElement, TKey, AgentIdentifier, long, Uuid, long, Guid, TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
        where TElement : IPermission<TElement, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatumLabelKey : unmanaged, IEquatable<TDatumLabelKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
        where TDatumLabel : IDatumLabel<TDatumLabel, TDatumLabelKey, TDatum, TDatumKey, TDatumValue>
    {
    }

    public interface IPermission<TElement, TKey, THierarchy, THierarchyKey>
        : IPermission<TElement, TKey>,
            IHierarchy<TElement, TKey, AgentIdentifier, long, Uuid, long, Guid, THierarchy, THierarchyKey>
        where TElement : IPermission<TElement, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where THierarchy : IHierarchy<THierarchy, THierarchyKey>
    {
    }
}
