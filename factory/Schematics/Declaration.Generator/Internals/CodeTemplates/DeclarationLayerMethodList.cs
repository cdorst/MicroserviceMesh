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
    internal static class DeclarationLayerMethodList
    {
        private const string Name = "GetEntities";
        private const string Type = "IEnumerable<Entity>";
        private static readonly DocumentationCommentList XmlDoc = Summary("Returns this Layer's Entity declarations");

        public static MethodList GetMethodList(in Layer layer)
            => Create(PublicStatic(Name, Type, BodyBlock(in layer), documentationCommentList: XmlDoc));

        private static DevOps.Primitives.CSharp.Block BodyBlock(in Layer layer)
            => Blocks.Create(BodyBlockStatements(layer).ToArray());

        private static IEnumerable<string> BodyBlockStatements(Layer layer)
        {
            foreach (var entity in layer.Entities)
            {
                entity.BlockName = layer.BlockName;
                entity.LayerName = layer.Name;
                var entityName = entity.GetTypeName().Type;
                yield return Concat("yield return ", entityName, ".Declaration;");
            }
        }
    }
}
