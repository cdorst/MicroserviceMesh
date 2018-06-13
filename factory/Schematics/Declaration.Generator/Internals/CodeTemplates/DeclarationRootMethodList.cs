using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using DevOps.Primitives.CSharp.Helpers.Common;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.CSharp.Helpers.Common.Comments;
using static DevOps.Primitives.CSharp.Helpers.Common.MethodLists;
using static DevOps.Primitives.CSharp.Helpers.Common.Methods;
using static System.String;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationRootMethodList
    {
        private const string Name = "GetDeclaration";
        private const string Type = "IEnumerable<IEnumerable<Entity>>";
        private static readonly DocumentationCommentList XmlDoc = Summary("Returns enumeration of Entity Layers");

        public static MethodList GetMethodList(in IEnumerable<Layer> layers)
            => Create(PublicStatic(Name, Type, BodyBlock(in layers), documentationCommentList: XmlDoc));

        private static DevOps.Primitives.CSharp.Block BodyBlock(in IEnumerable<Layer> layers)
            => Blocks.Create(BodyBlockStatements(layers).ToArray());

        private static IEnumerable<string> BodyBlockStatements(IEnumerable<Layer> layers)
        {
            foreach (var layer in layers)
                yield return Concat("yield return Layers.Block_", layer.BlockName, "_", layer.Name, ".Layer.GetEntities();");
        }
    }
}
