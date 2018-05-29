namespace Shared.Elements
{
    public interface IHierarchyAttribute<TElement, THierarchyKey, TAttribute, TAttributeKey> 
        : IElement<TElement, THierarchyKey>
        where THierarchyKey : unmanaged
        where TElement : IElement<TElement, THierarchyKey>
        where TAttributeKey : unmanaged
        where TAttribute : IHierarchy<TAttribute, TAttributeKey>
    {
        TAttribute Attribute { get; }
        TAttributeKey AttributeId { get; }
    }

    public interface IHierarchyAttribute<TElement, THierarchyKey, TAttribute, TAttributeKey, TAttributeDatum, TAttributeDatumKey, TAttributeDatumValue> 
        : IElement<TElement, THierarchyKey>
        where THierarchyKey : unmanaged
        where TElement : IElement<TElement, THierarchyKey>
        where TAttributeKey : unmanaged
        where TAttributeDatumKey : unmanaged
        where TAttributeDatum : IDatum<TAttributeDatum, TAttributeDatumKey, TAttributeDatumValue>
        where TAttribute : IDatumLabel<TAttribute, TAttributeKey, TAttributeDatum, TAttributeDatumKey, TAttributeDatumValue>
    {
        TAttribute Attribute { get; }
        TAttributeKey AttributeId { get; }
    }
}
