using System;

namespace Shared.Entities
{
    public interface IHierarchyAttribute<TEntity, THierarchyKey, TAttribute, TAttributeKey> 
        : IEntity<TEntity, THierarchyKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where TEntity : IEntity<TEntity, THierarchyKey>
        where TAttributeKey : unmanaged, IEquatable<TAttributeKey>
        where TAttribute : IHierarchy<TAttribute, TAttributeKey>
    {
        TAttribute Attribute { get; }
        TAttributeKey AttributeId { get; }
    }

    public interface IHierarchyAttribute<TEntity, THierarchyKey, TAttribute, TAttributeKey, TAttributeDatum, TAttributeDatumKey, TAttributeDatumValue> 
        : IEntity<TEntity, THierarchyKey>
        where THierarchyKey : unmanaged, IEquatable<THierarchyKey>
        where TEntity : IEntity<TEntity, THierarchyKey>
        where TAttributeKey : unmanaged, IEquatable<TAttributeKey>
        where TAttributeDatumKey : unmanaged, IEquatable<TAttributeDatumKey>
        where TAttributeDatum : IDatum<TAttributeDatum, TAttributeDatumKey, TAttributeDatumValue>
        where TAttribute : IDatumLabel<TAttribute, TAttributeKey, TAttributeDatum, TAttributeDatumKey, TAttributeDatumValue>
    {
        TAttribute Attribute { get; }
        TAttributeKey AttributeId { get; }
    }
}
