using System.Text;
using static Jigs.Program;
using static System.IO.File;
using static System.IO.Path;
using static System.String;

namespace Jigs
{
    public static class SharedEntityHierarchy
    {
        private const string AngleBraceClose = ">";
        private const string AngleBraceOpen = "<";
        private const string Comma = ",";
        private const string CommaSpace = ", ";
        private const string CurlyBraceClose = "}";
        private const string CurlyBraceOpen = "{";
        private const string Entities = nameof(Entities);
        private const string Getter = " { get; }";
        private const string IHierarchy = nameof(IHierarchy);
        private const byte MaxSameElements = 3;
        private const string PublicInterface = "public interface ";
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
        private static readonly string _path = Combine(SolutionPath, Shared, Entities, Concat(IHierarchy, ".cs"));

        public static void WriteFile() => WriteAllText(_path, GetFileContent());

        private static StringBuilder AppendBodyBlock(this StringBuilder stringBuilder)
            => stringBuilder
                .AppendLine(Concat(Tab, CurlyBraceOpen))
                .AppendLine(Concat(Tab, CurlyBraceClose));

        private static bool AppendCloseAngleBrace(in byte position, in byte last, in bool additionalPredicate = true)
            => additionalPredicate && position == last;

        private static bool AppendComma(in byte position, in byte last, in bool zeroHierarchies = true)
            => position < last || (position == last && !zeroHierarchies);

        private static bool AppendCommaLabels(in bool zeroHierarchies, in byte position, in byte last)
            => !zeroHierarchies || position < last;

        private static StringBuilder AppendGenericHierarchyConstraints(this StringBuilder stringBuilder, in byte quantity)
        {
            for (byte position = 1; position <= quantity; position++)
                stringBuilder.AppendHierarchyGenericConstraint(in position);
            return stringBuilder;
        }

        private static StringBuilder AppendGenericHierarchyTypes(this StringBuilder stringBuilder, in byte quantity, in byte labels)
        {
            for (byte position = 1; position <= quantity; position++)
                stringBuilder.AppendLine(Concat(TwoTabs, GetHierarchyGenerics(in position),
                    CommaOrEmpty(in position, in quantity),
                    CloseOrEmpty(in position, in quantity, in quantity, in labels)));
            return stringBuilder;
        }

        private static StringBuilder AppendGenericLabelConstraints(this StringBuilder stringBuilder, in byte quantity)
        {
            for (byte label = 1; label <= quantity; label++)
                stringBuilder.AppendLabelGenericConstraint(label);
            return stringBuilder;
        }

        private static StringBuilder AppendHierarchyGenericConstraint(this StringBuilder stringBuilder, in byte position = default)
        {
            var positionString = PositionOrEmpty(in position);
            return stringBuilder
                .AppendLine(Concat(TwoTabs, WhereUnmanaged(Concat(THierarchyKey, positionString))))
                .AppendLine(Concat(TwoTabs, Concat(WhereClause(Concat(THierarchy, positionString)), "IHierarchy<THierarchy", positionString, CommaSpace, "THierarchyKey", positionString, AngleBraceClose)));
        }

        private static StringBuilder AppendHierarchyMemberTypes(this StringBuilder stringBuilder)
        {
            for (byte position = 1; position <= MaxSameElements; position++)
            {
                stringBuilder
                .AppendLine(Concat(Tab, PublicInterface, IHierarchy, "MemberHierarchy", position, AngleBraceOpen, GetHierarchyGenerics(), AngleBraceClose))
                .AppendHierarchyGenericConstraint()
                .AppendLine(Concat(Tab, CurlyBraceOpen))
                .AppendLine(Concat(TwoTabs, THierarchy, " Hierarchy", position, Getter))
                .AppendLine(Concat(TwoTabs, THierarchyKey, " Hierarchy", position, "Id", Getter))
                .AppendLine(Concat(Tab, CurlyBraceClose));
                if (position != MaxSameElements) stringBuilder.AppendLine();
            }
            return stringBuilder;
        }

        private static StringBuilder AppendHierarchyTypes(this StringBuilder stringBuilder)
        {
            for (byte labels = 0; labels <= MaxSameElements; labels++)
                for (byte hierarchies = 0; hierarchies <= MaxSameElements; hierarchies++)
                {
                    if (labels + hierarchies == 0 || (labels == 0 && hierarchies == 1)) continue;
                    stringBuilder
                        .AppendLine(Concat(Tab, PublicInterface, IHierarchy, "<TEntity, TKey,"))
                        .AppendGenericLabelTypes(in labels, in hierarchies);
                    stringBuilder
                        .AppendGenericHierarchyTypes(in hierarchies, in labels)
                        .AppendLine(Concat(TwoTabs, WhereUnmanaged("TKey")))
                        .AppendLine(Concat(TwoTabs, Concat(WhereClause("TEntity"), "IEntity<TEntity, TKey>")))
                        .AppendGenericLabelConstraints(in labels)
                        .AppendGenericHierarchyConstraints(in hierarchies)
                        .AppendBodyBlock()
                        .AppendLine();
                }
            return stringBuilder;
        }

        private static StringBuilder AppendInterfaceGenericOverloads(this StringBuilder stringBuilder)
            => stringBuilder
                .AppendLine(Concat(Tab, PublicInterface, IHierarchy, "<TEntity, TKey> : IEntity<TEntity, TKey>"))
                .AppendLine(Concat(TwoTabs, WhereUnmanaged("TKey")))
                .AppendLine(Concat(TwoTabs, Concat(WhereClause("TEntity"), "IEntity<TEntity, TKey>")))
                .AppendBodyBlock()
                .AppendLine()
                .AppendHierarchyTypes()
                .AppendLabelMemberTypes()
                .AppendHierarchyMemberTypes();

        private static StringBuilder AppendLabelGenericConstraint(this StringBuilder stringBuilder, in byte position = default)
        {
            var positionString = PositionOrEmpty(in position);
            return stringBuilder
                .AppendLine(Concat(TwoTabs, WhereUnmanaged(Concat(TDatumKey, positionString))))
                .AppendLine(Concat(TwoTabs, WhereUnmanaged(Concat(TDatumLabelKey, positionString))))
                .AppendLine(Concat(TwoTabs, Concat(WhereClause(Concat(TDatum, positionString)), "IDatum<TDatum", positionString, CommaSpace, "TDatumKey", positionString, CommaSpace, TDatumValue, positionString, AngleBraceClose)))
                .AppendLine(Concat(TwoTabs, Concat(WhereClause(Concat(TDatumLabel, positionString)), "IDatumLabel<TDatumLabel", positionString, CommaSpace, "TDatumLabelKey", positionString, CommaSpace, TDatum, positionString, CommaSpace, TDatumKey, positionString, CommaSpace, TDatumValue, positionString, AngleBraceClose)));
        }

        private static StringBuilder AppendLabelMemberTypes(this StringBuilder stringBuilder)
        {
            for (byte position = 1; position <= MaxSameElements; position++) stringBuilder
                .AppendLine(Concat(Tab, PublicInterface, IHierarchy, "MemberDatumLabel", position, AngleBraceOpen, GetLabelGenerics(), AngleBraceClose))
                .AppendLabelGenericConstraint()
                .AppendLine(Concat(Tab, CurlyBraceOpen))
                .AppendLine(Concat(TwoTabs, TDatumLabel, " Label", position, Getter))
                .AppendLine(Concat(TwoTabs, TDatumLabelKey, " Label", position, "Id", Getter))
                .AppendLine(Concat(Tab, CurlyBraceClose))
                .AppendLine();
            return stringBuilder;
        }

        private static StringBuilder AppendGenericLabelTypes(this StringBuilder stringBuilder, in byte quantity, in byte hierarchies)
        {
            var zeroHierarchies = hierarchies == byte.MinValue;
            for (byte label = 1; label <= quantity; label++)
                stringBuilder.AppendLine(Concat(TwoTabs, GetLabelGenerics(in label),
                    CommaOrEmpty(in label, in quantity, in zeroHierarchies),
                    CloseOrEmpty(in label, in quantity, in hierarchies, in quantity, in zeroHierarchies)));
            return stringBuilder;
        }

        private static string AppendMemberBaseTypes(this string instance, in byte labels, in byte hierarchies)
        {
            var sb = new StringBuilder().Append(instance);
            sb.Append(AngleBraceClose).AppendLine(Comma);
            var zeroHierarchies = hierarchies == byte.MinValue;
            for (byte position = 1; position <= labels; position++)
                sb.AppendLine(Concat(ThreeTabs, "IHierarchyMemberDatumLabel", position, AngleBraceOpen, GetLabelGenerics(in position), AngleBraceClose, AppendCommaLabels(in zeroHierarchies, in position, in labels) ? Comma : Empty));
            for (byte position = 1; position <= hierarchies; position++)
                sb.AppendLine(Concat(ThreeTabs, "IHierarchyMemberHierarchy", position, AngleBraceOpen, GetHierarchyGenerics(in position), AngleBraceClose, position != hierarchies ? Comma : Empty));
            return sb.ToString().TrimEnd();
        }

        private static string CloseOrEmpty(in byte position, in byte last, in byte hierarchies = byte.MinValue, in byte labels = byte.MinValue, in bool additionalPredicate = true)
            => AppendCloseAngleBrace(in position, in last, in additionalPredicate)
                ? Concat(">\r\n\t\t: ", GetBaseType(in labels, in hierarchies))
                : Empty;

        private static string CommaOrEmpty(in byte position, in byte last, in bool zeroHierarchies = true)
            => AppendComma(in position, in last, in zeroHierarchies) ? Comma : Empty;

        private static string GetBaseType(in byte labels, in byte hierarchies)
            => labels + hierarchies == 1 || (labels == byte.MinValue && hierarchies == 2)
                ? "IHierarchy<TEntity, TKey".AppendMemberBaseTypes(in labels, in hierarchies)
                : GetBaseTypeSyntax(labels, hierarchies);

        private static string GetBaseTypeSyntax(byte labels, byte hierarchies)
        {
            if (labels > hierarchies) labels--;
            else hierarchies--;
            var zeroHierarchies = hierarchies == byte.MinValue;
            var sb = new StringBuilder().Append("IHierarchy<TEntity, TKey, ");
            for (byte position = 1; position <= labels; position++)
            {
                sb.Append(GetLabelGenerics(in position));
                if (AppendCommaLabels(in zeroHierarchies, in position, in labels))
                    sb.Append(zeroHierarchies ? Comma : CommaSpace);
            }
            for (byte position = 1; position <= hierarchies; position++)
            {
                sb.Append(GetHierarchyGenerics(in position));
                if (position < hierarchies) sb.Append(Comma);
            }
            return sb.ToString().AppendMemberBaseTypes(in labels, in hierarchies);
        }

        private static string GetFileContent()
            => GetFileContentPrefix()
                .AppendInterfaceGenericOverloads()
                .AppendLine(CurlyBraceClose)
                .ToString();

        private static StringBuilder GetFileContentPrefix()
            => new StringBuilder()
                .AppendLine(Concat("namespace ", Shared, ".", Entities))
                .AppendLine(CurlyBraceOpen);

        private static string GetHierarchyGenerics(in byte position = default)
        {
            var positionString = PositionOrEmpty(in position);
            return Concat(THierarchy, positionString, CommaSpace, THierarchyKey, positionString);
        }

        private static string GetLabelGenerics(in byte position = default)
        {
            var positionString = PositionOrEmpty(in position);
            return Concat(TDatumLabel, positionString, CommaSpace, TDatumLabelKey, positionString, CommaSpace, TDatum, positionString, CommaSpace, TDatumKey, positionString, CommaSpace, TDatumValue, positionString);
        }

        private static string PositionOrEmpty(in byte position)
            => position == byte.MinValue ? Empty : position.ToString();

        private static string WhereClause(in string name)
            => Concat("where ", name, " : ");

        private static string WhereUnmanaged(in string name)
            => Concat(WhereClause(name), "unmanaged");
    }
}
