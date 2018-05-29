using Shared.Elements.Primitives;
using System;

namespace Shared.Elements
{
    /// <summary>Use for datum permissions</summary>
    public interface IHierarchy<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        : IHierarchy<TElement, TKey, AgentIdentifier, long, Uuid, long, Guid>,
            IDatumLabel<TElement, TKey, TDatum, TDatumKey, TDatumValue>
        where TKey : unmanaged, IEquatable<TKey>
        where TElement : IPermission<TElement, TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
    }
}
