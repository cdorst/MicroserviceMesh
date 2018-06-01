using Declaration.Generator.Types;
using System;
using System.IO;
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
        private static readonly Deserializer _deserializer = new DeserializerBuilder()
            .WithNamingConvention(new CamelCaseNamingConvention())
            .Build();

        public static void Main(string[] args)
        {
            // TODO Read yml layers

            var blocks = EnumerateDirectories(Combine(CurrentDirectory, "Blocks"));
            foreach (var block in blocks)
            {
                var layers = EnumerateFiles(block);
                foreach (var layer in layers)
                {
                    var yaml = ReadAllText(layer);
                    var foo = _deserializer.Deserialize<Layer>(yaml);
                }
            }

            // TODO compose unified declaration

            // TODO write Declaration.Code.cs file
        }
    }
}
