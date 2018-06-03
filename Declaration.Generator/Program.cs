using Declaration.Generator.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public static async Task Main(string[] args = default)
            => await WriteAllTextAsync(Combine(_destinationRoot.Concat(, "foo.cs"), GetDeclaration());

        private static string GetDeclaration()
            => new DeclarationRoot(GetLayers()).ToString();

        private static Layer GetLayer(in string path, in string file)
            => _deserializer.Deserialize<Layer>(ReadAllText(Combine(path, file)));

        private static IEnumerable<Layer> GetLayers()
        {
            foreach (var block in EnumerateDirectories(_declarationPath))
                foreach (var layer in EnumerateFiles(block))
                    yield return GetLayer(in block, in layer);
        }


    }
}
