using Declaration.Generator.Internals.DeclarationTypes;
using Generator.Core;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerRootUsings;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationRootMethodList;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationRoot : DeclarationType
    {
        private const string Root = nameof(Root);
        private static readonly string XmlDocSummary = "Responsible for enumerating constituent Entity types";

        public static GeneratedFile GetRoot(in IEnumerable<Layer> layers, in IConfigurationRoot configuration)
            => new GeneratedFile(
                GetTypeDeclaration(Root, ProjectName, in configuration, in XmlDocSummary, in UsingDirectives, methodList: GetMethodList(in layers)),
                Root);
    }
}
