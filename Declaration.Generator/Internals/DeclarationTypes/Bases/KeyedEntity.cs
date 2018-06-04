using Declaration.Generator.Internals.DeclarationTypes.Exceptions;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using Acceptable = Declaration.Generator.Internals.DeclarationTypes.Validation.AcceptableValues;
using Default = Declaration.Generator.Internals.DeclarationTypes.Validation.DefaultValues;

namespace Declaration.Generator.Internals.DeclarationTypes.Bases
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
