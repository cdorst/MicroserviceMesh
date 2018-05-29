using System.Text;
using static Jigs.Program;
using static System.IO.File;
using static System.IO.Path;

namespace Jigs
{
    public static class SharedElementHierarchy
    {
        private static readonly string _path = Combine(SolutionPath, "Shared", "Elements", "IHierarchy.cs");

        public static void WriteFile() => WriteAllText(_path, GetFileContent());

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
