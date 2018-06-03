using System;

namespace Shared
{
    public static class EntityEquator
    {
        public static bool Equate<TEntity, TKey>(this TEntity entity, in TEntity other)
            where TKey : unmanaged, IEquatable<TKey>
            where TEntity : IEntity<TEntity, TKey>
            => entity.ToReadOnlySpan().SequenceEqual(other.ToReadOnlySpan());

        public static bool EquateWithKey<TEntity, TKey>(this TEntity entity, in TEntity other)
            where TKey : unmanaged, IEquatable<TKey>
            where TEntity : IEntity<TEntity, TKey>
            => entity.Id.Equals(other.Id) && entity.Equate<TEntity, TKey>(other);
    }
}
