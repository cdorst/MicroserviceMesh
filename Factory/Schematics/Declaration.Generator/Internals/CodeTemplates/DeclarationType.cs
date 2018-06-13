using DevOps.Primitives.CSharp;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.DeclarationCodeCopyrightFactory;
using static DevOps.Primitives.CSharp.Helpers.Common.Comments;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.String;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal abstract class DeclarationType
    {
        protected const string ProjectName = nameof(Declaration);
        private static readonly string _namespacePrefix = Concat(ProjectName, ".Layers.");

        protected static string GetTypeDeclaration(in string typeName, in string @namespace, in IConfigurationRoot configuration,
            in string typeSummaryDocumentation = default,
            in UsingDirectiveList usingDirectiveList = default,
            in FieldList fieldList = default,
            in MethodList methodList = default)
            => CSharpStaticClass(CopyrightValue(in configuration), ProjectName, typeName, @namespace, usingDirectiveList, Summary(typeSummaryDocumentation), fieldList: fieldList, methodList: methodList).Content.Value;

        protected static string GetTypeNamespace(in string folder, in string subfolder = default)
            => IsNullOrWhiteSpace(subfolder)
                ? Concat(_namespacePrefix, folder)
                : Concat(_namespacePrefix, folder, ".", subfolder);
    }
}
