using System.Text;
using static Jigs.Program;
using static System.IO.File;
using static System.IO.Path;
using static System.String;

namespace Jigs
{
    public static class SharedElementHierarchy
    {
        private const string CurlyBraceClose = "}";
        private const string CurlyBraceOpen = "{";
        private const string Elements = nameof(Elements);
        private const string IHierarchy = nameof(IHierarchy);
        private const byte MaxSameElements = 3;
        private const string Shared = nameof(Shared);
        private const string Tab = "\t";
        private static readonly string _path = Combine(SolutionPath, Shared, Elements, Concat(IHierarchy, ".cs"));

        public static void WriteFile() => WriteAllText(_path, GetFileContent());

        private static string GetFileContent()
            => GetFileContentPrefix()
                .AppendInterfaceGenericOverloads()
                .AppendLine(CurlyBraceClose)
                .ToString();

        private static StringBuilder AppendInterfaceGenericOverloads(this StringBuilder stringBuilder)
        {
            for (byte labels = 0; labels <= MaxSameElements; labels++)
                for (byte hierarchies = 0; hierarchies <= MaxSameElements; hierarchies++)
                {
                    if (labels + hierarchies == 0) continue;
                    stringBuilder.AppendLine(Concat(Tab, "public interface ", IHierarchy))
                        .AppendLine(Concat(Tab, CurlyBraceOpen))
                        .AppendLine(Concat(Tab, CurlyBraceClose));
                }
            return stringBuilder;
        }

        private static StringBuilder GetFileContentPrefix()
            => new StringBuilder()
                .AppendLine(Concat("namespace ", Shared, ".", Elements))
                .AppendLine(CurlyBraceOpen);
    }
}
