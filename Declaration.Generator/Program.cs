using Declaration.Generator.Types;
using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using static Declaration.Generator.FileWriter;
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

        public static void Main(string[] args = default)
            => WriteFiles(GetLayers());

        private static Layer GetLayer(in string path, in string file)
        {
            var layer = GetLayerFromYaml(in path, in file);
            layer.Name = file; // TODO parse name
            layer.BlockName = path; // TODO parse name
            return layer;
        }

        private static Layer GetLayerFromYaml(in string path, in string file)
            => _deserializer.Deserialize<Layer>(ReadAllText(Combine(path, file)));

        private static IEnumerable<Layer> GetLayers()
        {
            foreach (var block in EnumerateDirectories(_declarationPath))
                foreach (var layer in EnumerateFiles(block))
                    yield return GetLayer(in block, in layer);
        }

        private static void WriteFiles(in IEnumerable<Layer> layers)
        {
            foreach (var layer in layers)
            {
                var declaration = layer.AsDeclarationFile();
                WriteFile(in declaration.Contents, declaration.PathParts);
            }
        }
    }


}
