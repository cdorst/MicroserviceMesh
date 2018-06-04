using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.DeclarationCodeCopyrightFactory;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.String;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeGenerator
    {
        private const string ProjectName = nameof(Declaration);

        public static DeclarationFile GenerateCode(in Layer layer, in IConfigurationRoot configuration)
        {
            var pathParts = layer.GetPathParts();
            return new DeclarationFile(
                GetTypeDeclaration(in layer, in pathParts, in configuration),
                pathParts);
        }

        private static string GetTypeDeclaration(in Layer layer, in string[] pathParts, in IConfigurationRoot configuration)
            => CSharpStaticClass(
                copyright:      CopyrightValue(in configuration),
                projectName:    ProjectName,
                typeName:       layer.Name,
                @namespace:     GetTypeNamespace(in pathParts)
                ).Content.Value; // TODO add type members

        private static string GetTypeNamespace(in string[] pathParts)
            => Concat(ProjectName, ".Code", pathParts[0], ".", pathParts[1]);
    }
}
