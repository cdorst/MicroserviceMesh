using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using Field = DevOps.Primitives.CSharp.Helpers.Common.Fields;
using Fields = DevOps.Primitives.CSharp.Helpers.Common.FieldLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationEntityFieldList
    {
        private const string Comment = "Contains declaration representing this entity type";
        private const string Declaration = nameof(Declaration);
        private const string Entity = nameof(Entity);

        public static FieldList FieldList(in Entity entity)
            => Fields.Create(Field.PublicStaticReadonly(Declaration, Entity, Comment, initializer: Initializer(in entity)));

        private static string Initializer(in Entity entity)
            => "default";
    }
}
