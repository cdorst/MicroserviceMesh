using DevOps.Primitives.CSharp;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationLayerRootUsings
    {
        public static readonly UsingDirectiveList UsingDirectives = Usings.Create(
            "Declaration.Generator.Internals.DeclarationTypes",
            "System.Collections.Generic");
    }
}
