namespace Declaration.Generator.Internals.DeclarationTypes.Helpers
{
    public static class Entities
    {
        public static Entity Entity(in string block, in string layer, in string type, in Value value)
            => new Entity(in block, in layer, in type, in value);
    }
}
