using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.DeclarationCodeWriter;
using static System.Environment;

namespace Declaration.Generator
{
    public static class Program
    {
        private static readonly IConfigurationRoot Configuration
            = new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .AddJsonFile("configuration.json")
                .Build();

        public static void Main(string[] args = default)
            => WriteDeclarationCode(in Configuration);
    }
}
