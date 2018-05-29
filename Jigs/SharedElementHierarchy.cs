using System.IO;
using System.Text;

namespace Jigs
{
    public static class SharedElementHierarchy
    {
        private static readonly string _path = Path.Combine(Program.SolutionPath, "Shared", "Elements", "IHierarchy.cs");

        public static void WriteIHierarchyCsFile() => File.WriteAllText(_path, GetIHierarcyCs());

        private static string GetIHierarcyCs()
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
