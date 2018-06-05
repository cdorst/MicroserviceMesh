using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
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
        private const string QuoteCommaSpaceQuote = "\", \"";

        public static FieldList FieldList(in Entity entity, in Layer layer, in string typeName)
            => Create(PublicStaticReadonly(Declaration, Entity, Comment, initializer: Initializer(in entity, in layer, in typeName)));

        private static string Initializer(in Entity entity, in Layer layer, in string typeName)
            => Concat("Entity(\"", entity.BlockName, QuoteCommaSpaceQuote, entity.LayerName, QuoteCommaSpaceQuote, typeName, "\", default)");
    }
}
