namespace Declaration.Generator.Types.ValueTypes
{
    public readonly ref struct TypeName
    {
        public readonly string Namespace;
        public readonly string Type;

        public TypeName(in string @namespace, in string type)
        {
            Namespace = @namespace;
            Type = type;
        }
    }
}
