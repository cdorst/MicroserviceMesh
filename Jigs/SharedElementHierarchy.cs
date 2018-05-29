using System.IO;

namespace Jigs
{
    public static class SharedElementHierarchy
    {
        private static readonly string _path = Path.Combine(Program.SolutionPath, "Shared", "Elements", "IHierarchy.cs");

        public static void WriteIHierarchyCsFile() => File.WriteAllText(_path, GetIHierarcyCs());

        private static string GetIHierarcyCs() => string.Empty;
    }
}
