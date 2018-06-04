using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes.Validation
{
    public static class AcceptableValues
    {
        public static readonly HashSet<byte> KeySizes
            = new HashSet<byte>
            {
                (byte)KeySize._8,
                (byte)KeySize._16,
                (byte)KeySize._32,
                (byte)KeySize._64
            };
    }
}
