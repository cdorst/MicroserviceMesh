using System;

namespace Shared
{
    public static class ElementEquator
    {
        public static bool Equate<TElement, TKey>(this TElement element, in TElement other)
            where TKey : unmanaged, IEquatable<TKey>
            where TElement : IElement<TElement, TKey>
            => element.ToReadOnlySpan().SequenceEqual(other.ToReadOnlySpan());

        public static bool EquateWithKey<TElement, TKey>(this TElement element, in TElement other)
            where TKey : unmanaged, IEquatable<TKey>
            where TElement : IElement<TElement, TKey>
            => element.Id.Equals(other.Id) && element.Equate<TElement, TKey>(other);
    }
}
