using Declaration.Generator.Types;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.Environment;
using static System.String;

namespace Declaration.Generator
{
    internal static class DeclarationCodeGenerator
    {
        private const string ProjectName = nameof(Declaration);
        private static readonly string _copyrightEnvironmentValue = GetEnvironmentVariable("CodeGenerator_Copyright");
        private static readonly string _copyrightValue = Concat("Copyright © ",
            IsNullOrWhiteSpace(_copyrightEnvironmentValue) ? "Christopher Dorst" : _copyrightEnvironmentValue);

        public static DeclarationFile GenerateCode(in Layer layer)
        {
            var pathParts = layer.GetPathParts();
            return new DeclarationFile(
                GetTypeDeclaration(in layer, in pathParts),
                pathParts);
        }

        private static string GetTypeDeclaration(in Layer layer, in string[] pathParts)
            => CSharpStaticClass(_copyrightValue, ProjectName, layer.Name, GetTypeNamespace(in pathParts)).Content.Value; // TODO add type members

        private static string GetTypeNamespace(in string[] pathParts)
            => Concat(ProjectName, ".Code", pathParts[0], ".", pathParts[1]);
    }
}
