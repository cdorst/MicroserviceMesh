using Declaration.Generator.Types.ValueTypes;
using System.Collections.Generic;

namespace Declaration.Generator.Types.Validation
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
