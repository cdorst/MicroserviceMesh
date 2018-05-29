namespace Shared.Elements
{
    public interface IHierarchyAttribute<TElement, THierarchyKey, TAttribute, TAttributeKey> : IElement<TElement, THierarchyKey>
        where THierarchyKey : unmanaged
        where TElement : IElement<TElement, THierarchyKey>
        where TAttributeKey : unmanaged
        where TAttribute : IHierarchy<TAttributeKey>
    {
        TAttribute Attribute { get; }
        TAttributeKey AttributeId { get; }
    }
}
