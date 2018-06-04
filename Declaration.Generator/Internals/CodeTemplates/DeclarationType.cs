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

        protected static string GetTypeDeclaration(in string typeName, in string @namespace, in IConfigurationRoot configuration)
            => CSharpStaticClass(
                copyright: CopyrightValue(in configuration),
                projectName: ProjectName,
                typeName: typeName,
                @namespace: @namespace
                ).Content.Value; // TODO add type members

        protected static string GetTypeNamespace(in string folder, in string subfolder = default)
            => IsNullOrWhiteSpace(subfolder)
                ? Concat(_namespacePrefix, folder)
                : Concat(_namespacePrefix, folder, ".", subfolder);
    }
}
