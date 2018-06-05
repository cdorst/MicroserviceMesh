using static Declaration.Generator.Internals.ConfigurationFactory;
using static Declaration.Generator.Internals.DeclarationCodeWriter;

namespace Declaration.Generator
{
    public static class Program
    {
        public static void Main(string[] args = default)
            => WriteDeclarationCode(in Configuration);
    }
}
