using DevOps.Primitives.CSharp;
using Imports = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectives;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;
using static System.String;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationEntityUsingDirectiveList
    {
        public static UsingDirectiveList NamespaceImports(in string layerName, in Kind kind)
            => Usings.Create(
                Imports.Using("Declaration.Generator.Internals.DeclarationTypes"),
                Imports.UsingStatic(Concat("Declaration.Layers.", layerName, ".Constants")),
                Imports.UsingStatic("Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities"));
    }
}
