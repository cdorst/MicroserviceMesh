using System.IO;
using System.Linq;
using static System.Environment;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator.Internals
{
    internal static class FileWriter
    {
        private const string _extension = ".cs";
        private static readonly string[] _root = { new DirectoryInfo(CurrentDirectory).Parent.FullName, "Declaration", "Layers" };

        public static void WriteFile(in string content, in string[] pathParts)
             => WriteAllText(Path(in pathParts), content);

        private static string Path(in string[] parts)
            => Combine(PathArray(in parts));

        private static string[] PathArray(in string[] parts)
            => _root.Concat(parts.WithExtension()).ToArray();

        private static string[] WithExtension(this string[] parts)
        {
            var last = parts.Length - 1;
            if (parts[last].EndsWith(_extension)) return parts;
            parts[last] = string.Concat(parts[last], _extension);
            return parts;
        }
    }
}
