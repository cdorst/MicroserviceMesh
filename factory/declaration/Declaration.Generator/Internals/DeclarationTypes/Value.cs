using Declaration.Generator.Internals.DeclarationTypes.Bases;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Value : NamedTypedKeyedEntity
    {
        public Value() { }
        public Value(in string type, in string @namespace = default)
            : base(in type, in @namespace)
        {
        }
        public Value(in string type, in Attributes attributes, in string @namespace = default)
            : this(in type, in @namespace)
        {
            Attributes = attributes;
        }
        public Value(in string type, in ShadowAlternateKey alternateKey, in Attributes attributes = default, in string @namespace = default)
            : this(in type, in attributes, in @namespace)
        {
            ShadowAlternateKey = alternateKey;
        }

        public Attributes Attributes { get; set; }
        public ShadowAlternateKey ShadowAlternateKey { get; set; }
    }
}
