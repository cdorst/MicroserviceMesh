using DevOps.Primitives.CSharp;
using System.Collections.Generic;
using System.Linq;
using static System.String;
using Imports = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectives;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationEntityUsingDirectiveList
    {
        public static UsingDirectiveList NamespaceImports(in string layerName, in bool hasAttributes)
            => Usings.Create(Directives(layerName, hasAttributes).ToArray());

        private static IEnumerable<UsingDirective> Directives(string layerName, bool hasAttributes)
        {
            yield return Imports.Using("Declaration.Generator.Internals.DeclarationTypes");
            yield return Imports.UsingStatic(Concat("Declaration.Layers.", layerName, ".Constants"));
            yield return Imports.UsingStatic("Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities");
            if (hasAttributes)
                yield return Imports.UsingStatic("Declaration.Generator.Internals.DeclarationTypes.Helpers.ValueAttributes");
        }
    }
}
