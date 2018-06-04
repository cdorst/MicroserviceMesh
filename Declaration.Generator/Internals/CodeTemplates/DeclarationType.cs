using DevOps.Primitives.CSharp;
using DevOps.Primitives.CSharp.Helpers.Common;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.DeclarationCodeCopyrightFactory;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.String;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal abstract class DeclarationType
    {
        private const string ProjectName = nameof(Declaration);
        private static readonly string _namespacePrefix = Concat(ProjectName, ".Layers.");

        protected static string GetTypeDeclaration(in string typeName, in string @namespace, in IConfigurationRoot configuration,
            in string typeSummaryDocumentation = default,
            in UsingDirectiveList usingDirectiveList = default,
            in FieldList fieldList = default)
            => CSharpStaticClass(CopyrightValue(in configuration), ProjectName, typeName, @namespace, usingDirectiveList, Comments.Summary(typeSummaryDocumentation), fieldList: fieldList).Content.Value;

        protected static string GetTypeNamespace(in string folder, in string subfolder = default)
            => IsNullOrWhiteSpace(subfolder)
                ? Concat(_namespacePrefix, folder)
                : Concat(_namespacePrefix, folder, ".", subfolder);
    }
}
