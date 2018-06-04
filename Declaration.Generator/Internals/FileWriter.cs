using System.IO;
using System.Linq;
using static System.Environment;
using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator.Internals
{
    internal static class FileWriter
    {
        private const string _extension = ".cs";
        private static readonly string[] _root = { new DirectoryInfo(CurrentDirectory).Parent.FullName, "Declaration", "Layers" };

        public static void WriteFile(in string content, in string[] pathParts)
        {
            var directory = DirectoryPath(in pathParts);
            CreateDirectory(directory);
            WriteAllText(FilePath(in directory, fileName: pathParts.Last()), content);
        }

        private static string DirectoryPath(in string[] pathParts)
            => Combine(_root.Concat(pathParts.Take(pathParts.Length - 1)).ToArray());

        private static string FilePath(in string directory, in string fileName)
            => Combine(directory, string.Concat(fileName, _extension));
    }
}
