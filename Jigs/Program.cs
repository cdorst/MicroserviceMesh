using System;
using System.IO;
using static Jigs.SharedElementHierarchy;

namespace Jigs
{
    public static class Program
    {
        internal static readonly string SolutionPath = new DirectoryInfo(Environment.CurrentDirectory).Parent.FullName;

        public static void Main(string[] args) => WriteIHierarchyCsFile();
    }
}
