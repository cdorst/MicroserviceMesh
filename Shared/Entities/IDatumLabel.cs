using System;

namespace Shared.Entities
{
    public interface IDatumLabel<TEntity, TKey, TDatum, TDatumKey, TDatumValue> : IEntity<TEntity, TKey>
        where TKey : unmanaged, IEquatable<TKey>
        where TEntity : IEntity<TEntity, TKey>
        where TDatumKey : unmanaged, IEquatable<TDatumKey>
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
        TDatum Datum { get; }
        TDatumKey DatumId { get; }
    }
}
