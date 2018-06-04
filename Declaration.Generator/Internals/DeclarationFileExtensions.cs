using Declaration.Generator.Internals.DeclarationTypes;
using static Declaration.Generator.Internals.DeclarationCodeGenerator;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationFileExtensions
    {
        public static DeclarationFile AsDeclarationFile(this Layer layer) => GenerateCode(in layer);
    }
}
