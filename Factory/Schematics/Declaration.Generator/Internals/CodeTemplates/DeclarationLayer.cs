using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerMethodList;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationLayer : DeclarationType
    {
        private const string Layer = nameof(Layer);
        private static readonly UsingDirectiveList UsingDirectives = Usings.Create(
            "Declaration.Generator.Internals.DeclarationTypes",
            "System.Collections.Generic");
        private static readonly string XmlDocSummary = "Responsible for enumerating constituent Entity types";

        public static DeclarationFile GetLayer(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Layer, GetTypeNamespace(in path), in configuration, in XmlDocSummary, in UsingDirectives, methodList: GetMethodList(in layer)),
                path, Layer);
    }
}
