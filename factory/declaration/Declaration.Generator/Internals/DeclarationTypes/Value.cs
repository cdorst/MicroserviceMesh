using Declaration.Generator.Internals.DeclarationTypes.Bases;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Value : DifferentiatedEntity
    {
        public Value() { }
        public Value(in string type, in string @namespace = default, in string block = default, in string layer = default, in byte? keySize = default)
            : base(in type, in block, in layer, in @namespace, in keySize)
        {
        }
        public Value(in string type, in Attributes attributes, in string @namespace = default, in string block = default, in string layer = default, in byte? keySize = default)
            : this(in type, in @namespace, in block, in layer, in keySize)
        {
            Attributes = attributes;
        }
        public Value(in string type, in ShadowAlternateKey alternateKey, in Attributes attributes = default, in string @namespace = default, in string block = default, in string layer = default, in byte? keySize = default)
            : this(in type, in attributes, in @namespace, in block, in layer, in keySize)
        {
            ShadowAlternateKey = alternateKey;
        }

        public Attributes Attributes { get; set; }
        public ShadowAlternateKey ShadowAlternateKey { get; set; }
    }
}
