using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using Microsoft.Extensions.Configuration;
using static DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationEntity : DeclarationType
    {
        private const string Entities = nameof(Entities);

        public static DeclarationFile GetEntity(in Entity entity, in Layer layer, in string path, in IConfigurationRoot configuration)
        {
            entity.BlockName = layer.BlockName;
            entity.LayerName = layer.Name;
            var name = entity.GetTypeName().Type;
            return new DeclarationFile(
                GetTypeDeclaration(name, GetTypeNamespace(in path), in configuration, in UsingDirectiveList),
                path, Entities, name);
        }

        private static readonly UsingDirectiveList UsingDirectiveList = Create("Declaration.Generator.Internals");
    }
}
