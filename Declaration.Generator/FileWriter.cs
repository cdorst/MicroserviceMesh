using System.IO;
using System.Linq;
using static System.Environment;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator
{
    internal static class FileWriter
    {
        private const string _extension = ".cs";
        private static readonly string[] _directory = { new DirectoryInfo(CurrentDirectory).Parent.FullName, "Declaration", "Code" };

        public static void WriteFile(in string content, params string[] pathParts)
             => WriteAllText(Path(in pathParts), content);

        private static string Path(in string[] parts)
            => Combine(PathArray(in parts));

        private static string[] PathArray(in string[] parts)
            => _directory.Concat(WithExtension(parts)).ToArray();

        private static string[] WithExtension(string[] parts)
        {
            var last = parts.Length - 1;
            if (parts[last].EndsWith(_extension)) return parts;
            parts[last] = string.Concat(parts[last], _extension);
            return parts;
        }
    }
}
