using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Attributes
    {
        public Attributes() { }
        public Attributes(in List<string> listLiterals, in string columnType)
        {
            ColumnType = columnType;
            ListLiterals = listLiterals;
        }

        public List<string> ListLiterals { get; set; }
        public string ColumnType { get; set; }

        public IEnumerable<string> GetAttributeLists()
        {
            if (!string.IsNullOrWhiteSpace(ColumnType))
                yield return string.Concat(
                    "Column(TypeName = \"", ColumnType, "\")");

            if (ListLiterals != null)
                foreach (var list in ListLiterals)
                    yield return list;
        }
    }
}
