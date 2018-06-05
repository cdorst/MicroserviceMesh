using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationConstants : DeclarationType
    {
        private const string Constants = nameof(Constants);

        public static DeclarationFile GetConstants(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Constants, GetTypeNamespace(in path), in configuration),
                path, Constants);
    }
}
