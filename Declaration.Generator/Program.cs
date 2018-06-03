using Declaration.Generator.Types;
using System.Collections.Generic;
using static Declaration.Generator.DeclarationDeserializer;
using static Declaration.Generator.FileWriter;

namespace Declaration.Generator
{
    public static class Program
    {
        public static void Main(string[] args = default)
            => WriteFiles(DeserializeDeclaration());

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
