namespace Shared.Elements
{
    public interface IDatumLabel<TKey, TDatum, TDatumKey, TDatumValue> : IElement<TKey>
        where TKey : unmanaged
        where TDatumKey : unmanaged
        where TDatum : IDatum<TDatumKey, TDatumValue>
    {
        IDatum<TDatumKey, TDatumValue> Datum { get; }
        TDatumKey DatumId { get; }
    }
}
