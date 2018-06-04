namespace Declaration.Generator.Internals.DeclarationTypes.Bases
{
    public abstract class NamedTypeKeyedEntity : KeyedEntity
    {
        public NamedTypeKeyedEntity() : base() { }
        public NamedTypeKeyedEntity(in string type,
            in string @namespace = default,
            in byte? keySize = default)
            : base(in keySize)
        {
            Namespace = @namespace;
            Type = type;
        }

        public string Namespace { get; set; }
        public string Type { get; set; }
    }
}
