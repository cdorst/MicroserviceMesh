using Declaration.Generator.Internals.DeclarationTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using static Declaration.Generator.Internals.DeserializerFactory;
using static System.Environment;
using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationDeserializer
    {
        private static readonly string _path = Combine(CurrentDirectory, nameof(Declaration));
        private static readonly char[] _separators = { '/', '\\' };

        public static IEnumerable<Layer> DeserializeDeclaration()
        {
            foreach (var block in EnumerateDirectories(_path))
                foreach (var layer in EnumerateFiles(block))
                    yield return GetLayer(in block, in layer);
        }

        private static Layer GetLayer(in string path, in string file)
        {
            var layer = GetLayerFromYaml(in path, in file);
            layer.BlockName = NameOfBlock(in path);
            layer.Name = NameOfLayer(in file);
            return layer;
        }

        private static Layer GetLayerFromYaml(in string path, in string file)
            => Deserializer.Deserialize<Layer>(ReadAllText(Combine(path, file)));

        private static string LastElement(in string path) => path.Split(_separators).Last();
        private static string NameOfBlock(in string path) => LastElement(in path);
        private static string NameOfLayer(in string file) => LastElement(in file).Split('.').First();
    }
}
