using Declaration.Generator.Internals.DeclarationTypes;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using Generator.Core;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationEntityFieldList;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationEntityUsingDirectiveList;
using static System.String;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationEntity : DeclarationType
    {
        private const string Entities = nameof(Entities);

        public static GeneratedFile GetEntity(in Entity entity, in Layer layer, in string path, in IConfigurationRoot configuration)
        {
            entity.BlockName = layer.BlockName;
            entity.LayerName = layer.Name;
            var kind = entity.GetElementKind();
            var hasAttributes = kind == Kind.Datum && entity.Value?.Attributes != null;
            var name = entity.GetTypeName().Type;
            var comment = Concat("Contains declaration describing ", name, " entity types");
            return new GeneratedFile(
                GetTypeDeclaration(name, GetTypeNamespace(in path), in configuration, in comment, NamespaceImports(in path, in hasAttributes), FieldList(in entity, in name, in kind)),
                "Layers", path, Entities, name);
        }
    }
}
