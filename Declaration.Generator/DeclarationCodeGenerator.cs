using Declaration.Generator.Types;
using static Declaration.Generator.DeclarationCodeCopyrightFactory;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.String;

namespace Declaration.Generator
{
    internal static class DeclarationCodeGenerator
    {
        private const string ProjectName = nameof(Declaration);

        public static DeclarationFile GenerateCode(in Layer layer)
        {
            var pathParts = layer.GetPathParts();
            return new DeclarationFile(
                GetTypeDeclaration(in layer, in pathParts),
                pathParts);
        }

        private static string GetTypeDeclaration(in Layer layer, in string[] pathParts)
            => CSharpStaticClass(CopyrightValue, ProjectName, layer.Name, GetTypeNamespace(in pathParts)).Content.Value; // TODO add type members

        private static string GetTypeNamespace(in string[] pathParts)
            => Concat(ProjectName, ".Code", pathParts[0], ".", pathParts[1]);
    }
}
