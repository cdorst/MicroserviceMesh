using System.Text;
using static Jigs.Program;
using static System.IO.File;
using static System.IO.Path;
using static System.String;

namespace Jigs
{
    public static class SharedElementHierarchy
    {
        private const string CloseAngleBrace = ">";
        private const string Comma = ",";
        private const string CommaSpace = ", ";
        private const string CurlyBraceClose = "}";
        private const string CurlyBraceOpen = "{";
        private const string Elements = nameof(Elements);
        private const string IHierarchy = nameof(IHierarchy);
        private const byte MaxSameElements = 3;
        private const string Shared = nameof(Shared);
        private const string Tab = "\t";
        private const string TDatum = nameof(TDatum);
        private const string TDatumKey = nameof(TDatumKey);
        private const string TDatumLabel = nameof(TDatumLabel);
        private const string TDatumLabelKey = nameof(TDatumLabelKey);
        private const string TDatumValue = nameof(TDatumValue);
        private const string THierarchy = nameof(THierarchy);
        private const string THierarchyKey = nameof(THierarchyKey);
        private const string ThreeTabs = "\t\t\t";
        private const string TwoTabs = "\t\t";
        private static readonly string _path = Combine(SolutionPath, Shared, Elements, Concat(IHierarchy, ".cs"));

        public static void WriteFile() => WriteAllText(_path, GetFileContent());

        private static bool AppendCloseAngleBrace(in byte position, in byte last, in bool zeroHierarchies = true)
            => zeroHierarchies && position == last;

        private static bool AppendComma(in byte position, in byte last, in bool zeroHierarchies = true)
            => position < last || (position == last && !zeroHierarchies);

        private static StringBuilder AppendInterfaceGenericOverloads(this StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine(Concat(Tab, "public interface ", IHierarchy, "<TKey>"))
                .AppendLine(Concat(TwoTabs, WhereUnmanaged("TKey")))
                .AppendLine(Concat(Tab, CurlyBraceOpen))
                .AppendLine(Concat(Tab, CurlyBraceClose))
                .AppendLine();
            for (byte labels = 0; labels <= MaxSameElements; labels++)
                for (byte hierarchies = 0; hierarchies <= MaxSameElements; hierarchies++)
                {
                    if (labels + hierarchies == 0 || (labels == 0 && hierarchies == 1)) continue;
                    stringBuilder
                        .AppendLine(Concat(Tab, "public interface ", IHierarchy, "<TKey,"))
                        .AppendGenericLabelTypes(labels, hierarchies);
                    stringBuilder
                        .AppendGenericHierarchyTypes(hierarchies)
                        .AppendLine(Concat(TwoTabs, WhereUnmanaged("TKey")))
                        .AppendGenericLabelConstraints(labels)
                        .AppendGenericHierarchyConstraints(hierarchies)
                        .AppendLine(Concat(Tab, CurlyBraceOpen))
                        .AppendLine(Concat(Tab, CurlyBraceClose));
                    if (labels != MaxSameElements || hierarchies != MaxSameElements)
                        stringBuilder.AppendLine();
                }
            return stringBuilder;
        }

        private static StringBuilder AppendGenericHierarchyConstraints(this StringBuilder stringBuilder, in byte quantity)
        {
            for (byte position = 1; position <= quantity; position++)
                stringBuilder
                    .AppendLine(Concat(TwoTabs, WhereUnmanaged(Concat(THierarchyKey, position))))
                    .AppendLine(Concat(TwoTabs, Concat(WhereClause(Concat(THierarchy, position)), "IHierarchy<THierarchyKey", position, CloseAngleBrace)));
            return stringBuilder;
        }

        private static StringBuilder AppendGenericHierarchyTypes(this StringBuilder stringBuilder, in byte quantity)
        {
            for (byte label = 1; label <= quantity; label++)
                stringBuilder.AppendLine(Concat(TwoTabs, GetHierarchyGenerics(label),
                    CommaOrEmpty(in label, in quantity),
                    CloseOrEmpty(in label, in quantity)));
            return stringBuilder;
            string GetHierarchyGenerics(in byte position) => Concat(THierarchy, position, CommaSpace, THierarchyKey, position);
        }

        private static StringBuilder AppendGenericLabelConstraints(this StringBuilder stringBuilder, in byte quantity)
        {
            for (byte label = 1; label <= quantity; label++)
                stringBuilder
                    .AppendLine(Concat(TwoTabs, WhereUnmanaged(Concat(TDatumKey, label))))
                    .AppendLine(Concat(TwoTabs, WhereUnmanaged(Concat(TDatumLabelKey, label))))
                    .AppendLine(Concat(TwoTabs, Concat(WhereClause(Concat(TDatum, label)), "IDatum<TDatumKey", label, CommaSpace, TDatumValue, label, CloseAngleBrace)))
                    .AppendLine(Concat(TwoTabs, Concat(WhereClause(Concat(TDatumLabel, label)), "IDatumLabel<TDatumLabelKey", label, CommaSpace, TDatum, label, CommaSpace, TDatumKey, label, CommaSpace, TDatumValue, label, CloseAngleBrace)));
            return stringBuilder;
        }

        private static StringBuilder AppendGenericLabelTypes(this StringBuilder stringBuilder, in byte quantity, in byte hierarchies)
        {
            var noHierarchies = hierarchies == byte.MinValue;
            for (byte label = 1; label <= quantity; label++)
                stringBuilder.AppendLine(Concat(TwoTabs, GetLabelGenerics(label),
                    CommaOrEmpty(in label, in quantity, in noHierarchies),
                    CloseOrEmpty(in label, in quantity, in noHierarchies)));
            return stringBuilder;
            string GetLabelGenerics(in byte position) => Concat(TDatumLabel, position, CommaSpace, TDatumLabelKey, position, CommaSpace, TDatum, position, CommaSpace, TDatumKey, position, CommaSpace, TDatumValue, position);
        }

        private static string CloseOrEmpty(in byte position, in byte last, in bool zeroHierarchies = true)
            => AppendCloseAngleBrace(in position, in last, in zeroHierarchies) ? ">\r\n\t\t: IHierarchy<TKey>" : Empty;

        private static string CommaOrEmpty(in byte position, in byte last, in bool zeroHierarchies = true)
            => AppendComma(in position, in last, in zeroHierarchies) ? Comma : Empty;

        private static string GetFileContent()
            => GetFileContentPrefix()
                .AppendInterfaceGenericOverloads()
                .AppendLine(CurlyBraceClose)
                .ToString();

        private static StringBuilder GetFileContentPrefix()
            => new StringBuilder()
                .AppendLine(Concat("namespace ", Shared, ".", Elements))
                .AppendLine(CurlyBraceOpen);

        private static string WhereClause(in string name)
            => Concat("where ", name, " : ");

        private static string WhereUnmanaged(in string name)
            => Concat(WhereClause(name), "unmanaged");
    }
}
