using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationRoot;
using static Declaration.Generator.Internals.DeclarationCodeGenerator;
using static Declaration.Generator.Internals.DeclarationDeserializer;
using static Declaration.Generator.Internals.FileWriter;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeWriter
    {
        public static void WriteDeclarationCode(in IConfigurationRoot configuration)
            => WriteFiles(DeserializeDeclaration(), in configuration);

        private static void WriteFiles(in IEnumerable<Layer> layers, in IConfigurationRoot configuration)
        {
            WriteLayers(in layers, in configuration);
            WriteRoot(in layers, in configuration);
        }

        private static void WriteLayers(in IEnumerable<Layer> layers, in IConfigurationRoot configuration)
        {
            foreach (var layer in layers)
                foreach (var file in GenerateCode(layer, configuration))
                    WriteFile(in file.Contents, in file.PathParts);
        }

        private static void WriteRoot(in IEnumerable<Layer> layers, in IConfigurationRoot configuration)
        {
            var root = GetRoot(in layers, in configuration);
            WriteFile(in root.Contents, in root.PathParts);
        }
    }
}
