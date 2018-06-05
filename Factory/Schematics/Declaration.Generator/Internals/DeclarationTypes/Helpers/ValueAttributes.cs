using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes.Helpers
{
    public static class ValueAttributes
    {
        public static Attributes Attributes(
            in List<string> listLiterals = default,
            in string columnType = default)
            => new Attributes(in listLiterals, in columnType);
    }
}
