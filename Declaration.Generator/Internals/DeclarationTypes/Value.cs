using Declaration.Generator.Internals.DeclarationTypes.Bases;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Value : DifferentiatedEntity
    {
        public Attributes Attributes { get; set; }
        public ShadowAlternateKey ShadowAlternateKey { get; set; }
    }
}
