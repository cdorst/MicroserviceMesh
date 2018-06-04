using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
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
            foreach (var layer in layers)
            {
                var declaration = GenerateCode(in layer, in configuration);
                WriteFile(in declaration.Contents, in declaration.PathParts);
            }
        }
    }
}
