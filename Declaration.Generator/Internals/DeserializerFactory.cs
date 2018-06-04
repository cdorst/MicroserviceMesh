using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Declaration.Generator.Internals
{
    internal static class DeserializerFactory
    {
        public static readonly Deserializer Deserializer = new DeserializerBuilder()
            .WithNamingConvention(new CamelCaseNamingConvention())
            .Build();
    }
}
