using System.IO;
using static Jigs.SharedEntityHierarchy;
using static System.Environment;

namespace Jigs
{
    public static class Program
    {
        internal static readonly string SolutionPath = new DirectoryInfo(CurrentDirectory).Parent.FullName;

        public static void Main(string[] args) => WriteFile();
    }
}
