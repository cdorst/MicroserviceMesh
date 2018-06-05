using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationLayer : DeclarationType
    {
        private const string Layer = nameof(Layer);

        public static DeclarationFile GetLayer(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Layer, GetTypeNamespace(in path), in configuration),
                path, Layer);
    }
}
