using DevOps.Primitives.CSharp;
using Imports = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectives;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationEntityUsingDirectiveList
    {
        public static readonly UsingDirectiveList NamespaceImports = Usings.Create(
            Imports.Using("Declaration.Generator.Internals.DeclarationTypes"),
            Imports.UsingStatic("Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities"));
    }
}
