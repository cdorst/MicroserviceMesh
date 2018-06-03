using System.IO;
using System.Linq;
using static System.Environment;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator
{
    internal static class FileWriter
    {
        private static readonly string[] _fileExtension = { ".cs" };
        private static readonly string[] _rootDirectory = { new DirectoryInfo(CurrentDirectory).Parent.FullName, "Declaration", "Code" };

        public static void WriteFile(in string content, params string[] pathParts)
             => WriteAllText(
                 GetFilePath(in pathParts),
                 content);

        private static string GetFilePath(in string[] pathParts)
            => Combine(GetFilePathArray(in pathParts));

        private static string[] GetFilePathArray(in string[] pathParts)
            => _rootDirectory
                .Concat(pathParts)
                .Concat(_fileExtension)
                .ToArray();
    }
}
