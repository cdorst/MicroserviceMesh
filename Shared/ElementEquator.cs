using System;

namespace Shared
{
    public static class ElementEquator
    {
        public static bool Equate<TElement, TKey>(this TElement element, in TElement other)
            where TKey : unmanaged
            where TElement : IElement<TElement, TKey>
            => element.ToReadOnlySpan().SequenceEqual(other.ToReadOnlySpan());
    }
}
