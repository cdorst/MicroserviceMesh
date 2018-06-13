using static Declaration.Generator.Internals.DeclarationCodeWriter;
using static Generator.Core.ConfigurationFactory;
using static System.Console;

namespace Declaration.Generator
{
    public static class Program
    {
        public static void Main(string[] args = default)
        {
            WriteLine("Writing Declaration.Layers code...");
            WriteDeclarationCode(in Configuration);
            WriteLine("Finished!");
        }
    }
}
