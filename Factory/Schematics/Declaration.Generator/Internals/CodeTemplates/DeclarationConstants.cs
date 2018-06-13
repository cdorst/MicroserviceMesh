using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationConstantsFieldList;

namespace Declaration.Generator.Internals.CodeTemplates
{
    internal class DeclarationConstants : DeclarationType
    {
        private const string Constants = nameof(Constants);
        private const string Comment = "Contains BlockName and LayerName values";

        public static DeclarationFile GetConstants(in Layer layer, in string path, in IConfigurationRoot configuration)
            => new DeclarationFile(
                GetTypeDeclaration(Constants, GetTypeNamespace(in path), in configuration, Comment, fieldList: FieldList(in layer)),
                "Layers", path, Constants);
    }
}
