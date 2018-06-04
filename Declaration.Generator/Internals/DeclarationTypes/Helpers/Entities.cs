namespace Declaration.Generator.Internals.DeclarationTypes.Helpers
{
    public static class Entities
    {
        public static Entity Entity(in string block, in string layer, in string type, in Value value)
            => new Entity(in block, in layer, in type, in value);

        public static Entity Entity(in string block, in string layer, in string type, in string valueType, in string valueNamespace = default)
            => Entity(in block, in layer, in type, new Value(in valueType, in valueNamespace));

        public static Entity Entity(in string block, in string layer, in string type, in string valueType, in Attributes attributes, in string valueNamespace = default)
            => Entity(in block, in layer, in type, new Value(in valueType, in attributes, in valueNamespace));

        public static Entity Entity(in string block, in string layer, in string type, in string valueType, in ShadowAlternateKey alternateKey, in Attributes attributes = default, in string valueNamespace = default)
            => Entity(in block, in layer, in type, new Value(in valueType, in alternateKey, in attributes, in valueNamespace));
    }
}
