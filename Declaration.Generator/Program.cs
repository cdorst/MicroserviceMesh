using Declaration.Generator.Types;
using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using static System.Environment;
using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator
{
    public static class Program
    {
        private static readonly string _declarationPath = Combine(CurrentDirectory, "Blocks");
        private static readonly Deserializer _deserializer = new DeserializerBuilder()
            .WithNamingConvention(new CamelCaseNamingConvention())
            .Build();

        public static void Main(string[] args)
        {
            // Read yml layers
            var layers = GetLayers();

            // TODO compose unified declaration

            // TODO write Declaration.Code.cs file
        }

        private static Layer GetLayer(in string layerYml)
            => _deserializer.Deserialize<Layer>(ReadAllText(layerYml));

        private static IEnumerable<Layer> GetLayers()
        {
            foreach (var block in EnumerateDirectories(_declarationPath))
                yield return GetLayer(in block);
        }
    }
}
