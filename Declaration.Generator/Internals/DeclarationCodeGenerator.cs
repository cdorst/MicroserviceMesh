using Declaration.Generator.Internals.DeclarationTypes;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationEntity;
using static Declaration.Generator.Internals.CodeTemplates.DeclarationLayer;
using static System.String;

namespace Declaration.Generator.Internals
{
    internal static class DeclarationCodeGenerator
    {
        private const string Underscore = "_";

        public static IEnumerable<DeclarationFile> GenerateCode(Layer layer, IConfigurationRoot configuration)
        {
            var path = Concat("Block", Underscore, layer.BlockName, Underscore, layer.Name);

            // Declare file: Declaration/Layers/{path}/Layer.cs
            yield return GetLayer(in layer, in path, in configuration);

            foreach (var entity in layer.Entities)
                // Declare file: Declaration/Layers/{path}/Entities/{name}.cs
                yield return GetEntity(in entity, in layer, in path, in configuration);
        }
    }
}
