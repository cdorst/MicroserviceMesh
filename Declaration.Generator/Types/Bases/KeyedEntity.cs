using Declaration.Generator.Types.Exceptions;
using Declaration.Generator.Types.ValueTypes;
using Acceptable = Declaration.Generator.Types.Validation.AcceptableValues;
using Default = Declaration.Generator.Types.Validation.DefaultValues;

namespace Declaration.Generator.Types.Bases
{
    public abstract class KeyedEntity : IKeyable
    {
        public byte? KeySize { get; set; }

        public KeySize GetKeySize() =>
            !KeySize.HasValue ? Default.KeySize
            : Acceptable.KeySizes.Contains(KeySize.Value) ? (KeySize)KeySize.Value
            : throw new KeySizeNotInferrableException();
    }
}
