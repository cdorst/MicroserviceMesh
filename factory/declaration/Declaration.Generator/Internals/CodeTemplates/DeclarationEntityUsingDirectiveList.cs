using DevOps.Primitives.CSharp;
using DevOps.Primitives.CSharp.Helpers.Common;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationEntityUsingDirectiveList
    {
        public static readonly UsingDirectiveList NamespaceImports = Usings.Create(
            UsingDirectives.UsingStatic("Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities"));
    }
}
