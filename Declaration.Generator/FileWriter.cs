using System.IO;
using System.Linq;
using static System.Environment;
using static System.IO.File;
using static System.IO.Path;

namespace Declaration.Generator
{
    internal static class FileWriter
    {
        private static readonly string[] _csFileExtension = { ".cs" };
        private static readonly string[] _destinationRoot = { new DirectoryInfo(CurrentDirectory).Parent.FullName, "Declaration", "Code" };

        public static void WriteFile(in string content, params string[] pathParts)
             => WriteAllText(
                 GetFilePath(in pathParts),
                 content);

        private static string GetFilePath(in string[] pathParts)
            => Combine(GetFilePathPartArray(in pathParts));

        private static string[] GetFilePathPartArray(in string[] pathParts)
            => _destinationRoot
                .Concat(pathParts)
                .Concat(_csFileExtension)
                .ToArray();
    }
}
