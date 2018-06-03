using Declaration.Generator.Types.Bases;

namespace Declaration.Generator.Types
{
    public class Value : DifferentiatedEntity
    {
        public Attributes Attributes { get; set; }
        public ShadowAlternateKey ShadowAlternateKey { get; set; }
    }
}
