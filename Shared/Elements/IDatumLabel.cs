namespace Shared.Elements
{
    public interface IDatumLabel<TElement, TKey, TDatum, TDatumKey, TDatumValue> : IElement<TElement, TKey>
        where TKey : unmanaged
        where TElement : IElement<TElement, TKey>
        where TDatumKey : unmanaged
        where TDatum : IDatum<TDatum, TDatumKey, TDatumValue>
    {
        TDatum Datum { get; }
        TDatumKey DatumId { get; }
    }
}
