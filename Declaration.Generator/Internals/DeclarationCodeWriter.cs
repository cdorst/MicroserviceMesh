using Declaration.Generator.Internals.DeclarationTypes;
using System.Collections.Generic;
using static Declaration.Generator.Internals.DeclarationDeserializer;
using static Declaration.Generator.Internals.FileWriter;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeWriter
    {
        public static void WriteDeclarationCode() => WriteFiles(DeserializeDeclaration());

        private static void WriteFiles(in IEnumerable<Layer> layers)
        {
            foreach (var layer in layers)
            {
                var declaration = layer.AsDeclarationFile();
                WriteFile(in declaration.Contents, declaration.PathParts);
            }
        }
    }
}
