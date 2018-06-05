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
        private const string Comment = "Contains declaration representing this entity type";
        private const string Declaration = nameof(Declaration);
        private const string Entity = nameof(Entity);
        private const string Quote = "\"";

        public static FieldList FieldList(in Entity entity, in string typeName)
            => Create(PublicStaticReadonly(Declaration, Entity, Comment, initializer: Initializer(in entity, in typeName)));

        private static string Initializer(in Entity entity, in string typeName)
            => Concat("Entity(BlockName, LayerName, nameof(", typeName, "), ", KindArguments(in entity), ")");

        private static string KindArguments(in Entity entity)
        {
            var kind = entity.GetElementKind();
            switch (kind)
            {
                case Kind.Datum:
                    return FormatDatum(in entity);
                case Kind.DatumLabel:
                    return "default";
                case Kind.Hierarchy:
                    return "default";
                case Kind.HierarchyAttribute:
                    return "default";
            }
            throw new NotImplementedException("Entity kind case not handled");
            string FormatDatum(in Entity type)
            {
                var value = type.Value;
                var stringBuilder = new StringBuilder();
                stringBuilder.Append(Quote).Append(value.Type).Append(Quote);
                return stringBuilder.ToString();
            }
        }
    }
}
