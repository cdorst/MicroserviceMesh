using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Declaration.Generator
{
    internal static class DeserializerFactory
    {
        public static readonly Deserializer Deserializer = new DeserializerBuilder()
            .WithNamingConvention(new CamelCaseNamingConvention())
            .Build();
    }
}
