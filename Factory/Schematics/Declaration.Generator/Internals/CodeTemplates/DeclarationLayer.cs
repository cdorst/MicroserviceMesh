using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerMethodList;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerRootUsings;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationLayer : DeclarationType
    {
        private const string Layer = nameof(Layer);
        private static readonly string XmlDocSummary = "Responsible for enumerating constituent Entity types";

        public static DeclarationFile GetLayer(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Layer, GetTypeNamespace(in path), in configuration, in XmlDocSummary, in UsingDirectives, methodList: GetMethodList(in layer)),
                "Layers", path, Layer);
    }
}
