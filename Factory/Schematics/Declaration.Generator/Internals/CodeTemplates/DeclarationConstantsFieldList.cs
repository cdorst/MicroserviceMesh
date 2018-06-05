using Declaration.Generator.Internals.DeclarationTypes;
using DevOps.Primitives.CSharp;
using static DevOps.Primitives.CSharp.Helpers.Common.FieldLists;
using static DevOps.Primitives.CSharp.Helpers.Common.Fields;
using static System.String;
using static DevOps.Primitives.CSharp.Helpers.Common.TypeConstants;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal static class DeclarationConstantsFieldList
    {
        private const string BlockComment = "The name of this layer's surrounding block";
        private const string BlockName = nameof(BlockName);
        private const string Quote = "\"";
        private const string LayerComment = "The name of this layer";
        private const string LayerName = nameof(LayerName);

        public static FieldList FieldList(in Layer layer)
            => Create(
                BlockNameField(in layer),
                LayerNameField(in layer));

        private static Field BlockNameField(in Layer layer)
            => PublicConst(BlockName, String, BlockComment, initializer: Format(layer.BlockName));

        private static string Format(in string value)
            => Concat(Quote, value, Quote);

        private static Field LayerNameField(in Layer layer)
            => PublicConst(LayerName, String, LayerComment, initializer: Format(layer.Name));
    }
}
