using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationEntityFieldList;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationEntityUsingDirectiveList;
using static System.String;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationEntity : DeclarationType
    {
        private const string Entities = nameof(Entities);

        public static DeclarationFile GetEntity(in Entity entity, in Layer layer, in string path, in IConfigurationRoot configuration)
        {
            entity.BlockName = layer.BlockName;
            entity.LayerName = layer.Name;
            var kind = entity.GetElementKind();
            var name = entity.GetTypeName().Type;
            var comment = Concat("Contains declaration describing ", name, " entity types");
            return new DeclarationFile(
                GetTypeDeclaration(name, GetTypeNamespace(in path), in configuration, in comment, NamespaceImports(in path, in kind), FieldList(in entity, in name, in kind)),
                path, Entities, name);
        }
    }
}
