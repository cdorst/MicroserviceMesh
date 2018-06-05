using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationEntityFieldList;
using static System.String;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationEntity : DeclarationType
    {
        private const string Entities = nameof(Entities);

        private static readonly UsingDirectiveList UsingDirectiveList = Usings.Create("Declaration.Generator.Internals.DeclarationTypes");

        public static DeclarationFile GetEntity(in Entity entity, in Layer layer, in string path, in IConfigurationRoot configuration)
        {
            entity.BlockName = layer.BlockName;
            entity.LayerName = layer.Name;
            var name = entity.GetTypeName().Type;
            var comment = Concat("Contains declaration describing ", name, " entity types");
            return new DeclarationFile(
                GetTypeDeclaration(name, GetTypeNamespace(in path), in configuration, in comment, in UsingDirectiveList, FieldList(in entity)),
                path, Entities, name);
        }
    }
}
