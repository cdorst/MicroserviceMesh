using Declaration.Generator.Internals.DeclarationTypes;
using Generator.Core;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerMethodList;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerRootUsings;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationLayer : DeclarationType
    {
        private const string Layer = nameof(Layer);
        private static readonly string XmlDocSummary = "Responsible for enumerating constituent Entity types";

        public static GeneratedFile GetLayer(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new GeneratedFile(
                GetTypeDeclaration(Layer, GetTypeNamespace(in path), in configuration, in XmlDocSummary, in UsingDirectives, methodList: GetMethodList(in layer)),
                "Layers", path, Layer);
    }
}
