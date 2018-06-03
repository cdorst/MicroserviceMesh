using Declaration.Generator.Types;
using static Declaration.Generator.DeclarationCodeGenerator;

namespace Declaration.Generator
{
    internal static class DeclarationFileExtensions
    {
        public static DeclarationFile AsDeclarationFile(this Layer layer)
            => GetDeclaration(in layer);

        private static DeclarationFile GetDeclaration(in Layer layer)
            => new DeclarationFile(GenerateCode(in layer), layer.GetPathParts());
    }
}
