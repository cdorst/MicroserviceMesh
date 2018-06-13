using System.Collections.Generic;
using System.Linq;
using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace Generator.Core
{
    public static class FileWriter
    {
        private const string _extension = ".cs";

        public static void WriteFile(in GeneratedFile file, in string[] root)
            => WriteFile(in file.Contents, in file.PathParts, in root);

        public static void WriteFile(in string content, in string[] pathParts, in string[] root)
        {
            var directory = DirectoryPath(in pathParts, in root);
            CreateDirectory(directory);
            WriteAllText(FilePath(in directory, fileName: pathParts.Last()), content);
        }

        private static string DirectoryPath(in string[] parts, in string[] root)
            => Combine(root.Concat(parts.WithoutFileName()).ToArray());

        private static string FilePath(in string directory, in string fileName)
            => Combine(directory, string.Concat(fileName, _extension));

        private static IEnumerable<string> WithoutFileName(this string[] parts)
            => parts.Take(parts.Length - 1);
    }
}
