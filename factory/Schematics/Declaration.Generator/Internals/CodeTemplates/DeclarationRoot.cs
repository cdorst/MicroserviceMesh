using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationRootMethodList;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayerRootUsings;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationRoot : DeclarationType
    {
        private const string Root = nameof(Root);
        private static readonly string XmlDocSummary = "Responsible for enumerating constituent Entity types";

        public static DeclarationFile GetRoot(in IEnumerable<Layer> layers, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Root, ProjectName, in configuration, in XmlDocSummary, in UsingDirectives, methodList: GetMethodList(in layers)),
                Root);
    }
}
