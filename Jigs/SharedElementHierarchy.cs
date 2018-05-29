using System.IO;
using System.Text;

namespace Jigs
{
    public static class SharedElementHierarchy
    {
        private static readonly string _path = Path.Combine(Program.SolutionPath, "Shared", "Elements", "IHierarchy.cs");

        public static void WriteFile() => File.WriteAllText(_path, GetFileContent());

        private static string GetFileContent()
            => new StringBuilder()
                .AppendLine("namespace Shared.Elements")
                .AppendLine("{")
                .AppendLine("\tpublic interface IHierarchy")
                .AppendLine("\t{")
                .AppendLine("\t}")
                .AppendLine("}")
                .ToString();
    }
}
