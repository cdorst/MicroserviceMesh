namespace Shared.Elements
{
    public interface IHierarchyAttribute<THierarchyKey, TAttribute, TAttributeKey> : IElement<THierarchyKey>
        where TAttributeKey : unmanaged
        where THierarchyKey : unmanaged
        where TAttribute : IHierarchy<TAttributeKey>
    {
        TAttribute Attribute { get; }
        TAttributeKey AttributeId { get; }
    }
}
