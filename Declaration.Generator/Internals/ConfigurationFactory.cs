using Microsoft.Extensions.Configuration;
using static System.Environment;

namespace Declaration.Generator.Internals
{
    internal static class ConfigurationFactory
    {
        public static readonly IConfigurationRoot Configuration
            = new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .AddJsonFile("configuration.json")
                .Build();
    }
}
