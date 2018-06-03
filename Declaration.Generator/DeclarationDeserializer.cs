﻿using Declaration.Generator.Types;
using System.Collections.Generic;
using static Declaration.Generator.DeserializerFactory;
using static System.Environment;
using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator
{
    internal static class DeclarationDeserializer
    {
        private static readonly string _declarationPath = Combine(CurrentDirectory, "Blocks");

        public static IEnumerable<Layer> DeserializeDeclaration()
        {
            foreach (var block in EnumerateDirectories(_declarationPath))
                foreach (var layer in EnumerateFiles(block))
                    yield return GetLayer(in block, in layer);
        }

        private static Layer GetLayer(in string path, in string file)
        {
            var layer = GetLayerFromYaml(in path, in file);
            layer.Name = file; // TODO parse name
            layer.BlockName = path; // TODO parse name
            return layer;
        }

        private static Layer GetLayerFromYaml(in string path, in string file)
            => Deserializer.Deserialize<Layer>(ReadAllText(Combine(path, file)));
    }
}
