using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using DevOps.Primitives.CSharp.Helpers.Common;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using static DevOps.Primitives.CSharp.Helpers.Common.Comments;
using static DevOps.Primitives.CSharp.Helpers.Common.MethodLists;
using static DevOps.Primitives.CSharp.Helpers.Common.Methods;
using static System.String;
using Usings = DevOps.Primitives.CSharp.Helpers.Common.UsingDirectiveLists;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationLayer : DeclarationType
    {
        private const string Layer = nameof(Layer);
        private const string MethodName = "GetEntities";
        private const string MethodType = "IEnumerable<Entity>";
        private const string MethodXmlDoc = "Returns this Layer's Entity declarations";
        private static readonly UsingDirectiveList UsingDirectives = Usings.Create(
            "Declaration.Generator.Internals.DeclarationTypes",
            "System.Collections.Generic");
        private static readonly string XmlDocSummary = "Responsible for enumerating constituent Entity types";

        public static DeclarationFile GetLayer(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Layer, GetTypeNamespace(in path), in configuration, in XmlDocSummary, in UsingDirectives, methodList: GetLayerMethodList(in layer)),
                path, Layer);

        private static MethodList GetLayerMethodList(in Layer layer)
            => Create(PublicStatic(MethodName, MethodType,
                Blocks.Create(GetMethodBody(layer).ToArray()),
                documentationCommentList: Summary(MethodXmlDoc)));

        private static IEnumerable<string> GetMethodBody(Layer layer)
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
