using Declaration.Generator.Types;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.Environment;
using static System.String;

namespace Declaration.Generator
{
    internal static class DeclarationCodeGenerator
    {
        private const string ProjectName = nameof(Declaration);
        private static readonly string _copyrightEnvironmentValue = GetEnvironmentVariable("FooBar");
        private static readonly string _copyrightValue = Concat("Copyright © ",
            IsNullOrWhiteSpace(_copyrightEnvironmentValue) ? "Christopher Dorst" : _copyrightEnvironmentValue);

        public static string GenerateCode(in Layer layer) => CSharpStaticClass(_copyrightValue, ProjectName, layer.Name)
    }
}
