using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using Microsoft.Extensions.Configuration;
using static System.String;
using Field = DevOps.Primitives.CSharp.Helpers.Common.Fields;
using Fields = DevOps.Primitives.CSharp.Helpers.Common.FieldLists;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationEntity : DeclarationType
    {
        private const string Comment = "Contains declaration representing this entity type";
        private const string Declaration = nameof(Declaration);
        private const string Entities = nameof(Entities);
        private const string Entity = nameof(Entity);

        public static DeclarationFile GetEntity(in Entity entity, in Layer layer, in string path, in IConfigurationRoot configuration)
        {
            entity.BlockName = layer.BlockName;
            entity.LayerName = layer.Name;
            var name = entity.GetTypeName().Type;
            var comment = Concat("Contains declaration describing ", name, " entity types");
            return new DeclarationFile(
                GetTypeDeclaration(name, GetTypeNamespace(in path), in configuration, in comment, in UsingDirectiveList, in FieldList),
                path, Entities, name);
        }

        private static readonly FieldList FieldList = Fields.Create(Field.PublicStaticReadonly(Declaration, Entity, Comment, initializer: "default"));
        private static readonly UsingDirectiveList UsingDirectiveList = Usings.Create("Declaration.Generator.Internals.DeclarationTypes");
    }
}
