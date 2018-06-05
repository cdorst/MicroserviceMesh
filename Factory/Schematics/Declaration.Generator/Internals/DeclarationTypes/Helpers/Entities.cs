namespace Declaration.Generator.Internals.DeclarationTypes.Helpers
{
    public static class Entities
    {
        public static Entity Entity(in string block, in string layer, in string type, in Value value, in byte? keySize = default)
            => new Entity(in block, in layer, in type, in value, in keySize);

        public static Entity Entity(in string block, in string layer, in string type, in string valueType, in string valueNamespace = default, in byte? keySize = default)
            => Entity(in block, in layer, in type, new Value(in valueType, in valueNamespace), in keySize);

        public static Entity Entity(in string block, in string layer, in string type, in string valueType, in Attributes attributes, in string valueNamespace = default, in byte? keySize = default)
            => Entity(in block, in layer, in type, new Value(in valueType, in attributes, in valueNamespace), in keySize);

        public static Entity Entity(in string block, in string layer, in string type, in string valueType, in ShadowAlternateKey alternateKey, in Attributes attributes = default, in string valueNamespace = default, in byte? keySize = default)
            => Entity(in block, in layer, in type, new Value(in valueType, in alternateKey, in attributes, in valueNamespace), in keySize);
    }
}
