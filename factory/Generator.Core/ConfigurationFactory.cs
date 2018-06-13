using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using static System.Reflection.Assembly;
using static System.Environment;

namespace Generator.Core
{
    public static class ConfigurationFactory
    {
        private static readonly IFileProvider _provider = new EmbeddedFileProvider(GetAssembly(typeof(ConfigurationFactory)));

        public static readonly IConfigurationRoot Configuration
            = new ConfigurationBuilder()
                .SetBasePath(CurrentDirectory)
                .SetFileProvider(_provider)
                .AddJsonFile("configuration.json")
                .Build();
    }
}
