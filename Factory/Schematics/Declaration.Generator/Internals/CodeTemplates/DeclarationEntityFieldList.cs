using Declaration.Generator.Internals.DeclarationTypes;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using DevOps.Primitives.CSharp;
using System;
using System.Text;
using static DevOps.Primitives.CSharp.Helpers.Common.FieldLists;
using static DevOps.Primitives.CSharp.Helpers.Common.Fields;
using static System.String;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationEntityFieldList
    {
        private const string CommaSpace = ", ";
        private const string Comment = "Contains declaration representing this entity type";
        private const string Declaration = nameof(Declaration);
        private const string Entity = nameof(Entity);
        private const string Quote = "\"";

        public static FieldList FieldList(in Entity entity, in string typeName, in Kind kind)
            => Create(PublicStaticReadonly(Declaration, Entity, Comment, initializer: Initializer(in entity, in typeName, in kind)));

        private static string Initializer(in Entity entity, in string typeName, in Kind kind)
            => Concat("Entity(BlockName, LayerName, nameof(", typeName, "), ", KindArguments(in entity, in kind), ")");

        private static string KindArguments(in Entity entity, in Kind kind)
        {
            switch (kind)
            {
                case Kind.Datum:
                    return FormatDatum(in entity);
                case Kind.DatumLabel:
                    return "default, default";
                case Kind.Hierarchy:
                    return "default, default";
                case Kind.HierarchyAttribute:
                    return "default, default";
            }
            throw new NotImplementedException("Entity kind case not handled");
            string FormatAttributes(in Attributes attributes)
            {
                if (attributes.ListLiterals == null)
                    return Concat("Attributes(columnType: \"", attributes.ColumnType, "\")");
                throw new NotImplementedException("Attribute ListLiterals not yet implemented");
            }
            string FormatDatum(in Entity type)
            {
                var value = type.Value;
                var stringBuilder = new StringBuilder();
                stringBuilder.Append("valueType: ").Append(Quote).Append(value.Type).Append(Quote);
                if (value.AlternateKey != null)
                    stringBuilder.Append(CommaSpace).Append("alternateKey: ").Append("default");
                if (!IsNullOrWhiteSpace(value.Namespace))
                    stringBuilder.Append(CommaSpace).Append("valueNamespace: ").Append(Quote).Append(value.Namespace).Append(Quote);
                var attributes = value.Attributes;
                if (attributes != null)
                    stringBuilder.Append(CommaSpace).Append("attributes: ").Append(FormatAttributes(in attributes));
                return stringBuilder.Append(CommaSpace).Append("keySize: ").Append(((byte)value.GetKeySize()).ToString()).ToString();
            }
        }
    }
}
