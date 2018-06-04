using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using static Declaration.Generator.Internals.DeclarationCodeCopyrightFactory;
using static DevOps.Primitives.SourceGraph.Helpers.DotNetCore.Common.Files.CSharpCode;
using static System.String;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeGenerator
    {
        private const string Entity = nameof(Entity);
        private const string Layers = nameof(Layers);
        private const string ProjectName = nameof(Declaration);
        private static readonly string _namespacePrefix = Concat(ProjectName, ".Layers.");

        public static IEnumerable<DeclarationFile> GenerateCode(Layer layer, IConfigurationRoot configuration)
        {
            var path = Concat(layer.BlockName, "_", layer.Name);

            // Declare file: Declaration/Layers/{path}/Layer.cs
            yield return GetLayer(in layer, in path, in configuration);

            foreach (var entity in layer.Entities)
                // Declare file: Declaration/Layers/{path}/Entities/{name}.cs
                yield return GetEntity(in layer, in path, in configuration);
        }

        private static DeclarationFile GetEntity(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(in layer, GetTypeNamespace(in path), in configuration),
                path);

        private static DeclarationFile GetLayer(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(in layer, GetTypeNamespace(in path), in configuration),
                path);

        private static string GetTypeDeclaration(in Layer layer, in string @namespace, in IConfigurationRoot configuration)
            => CSharpStaticClass(
                copyright:      CopyrightValue(in configuration),
                projectName:    ProjectName,
                typeName:       layer.Name,
                @namespace:     @namespace
                ).Content.Value; // TODO add type members

        private static string GetTypeNamespace(in string folder, in string subfolder = default)
            => IsNullOrWhiteSpace(subfolder)
                ? Concat(_namespacePrefix, folder)
                : Concat(_namespacePrefix, folder, ".", subfolder);
    }
}
