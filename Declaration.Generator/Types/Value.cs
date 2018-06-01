using Declaration.Generator.Types.Bases;

namespace Declaration.Generator.Types
{
    public class Value : TypedKeyedElement
    {
        public Attributes Attributes { get; set; }
        public ShadowAlternateKey ShadowAlternateKey { get; set; }
    }
}
