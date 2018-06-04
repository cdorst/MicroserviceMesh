using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.DeclarationCodeWriter;
using static System.Environment;

namespace Declaration.Generator
{
    public static class Program
    {
        public static void Main(string[] args = default)
            => WriteDeclarationCode(GetConfiguration());

        private static IConfigurationRoot GetConfiguration()
            => new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .AddJsonFile("configuration.json")
                .Build();
    }
}
