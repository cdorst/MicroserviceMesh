using Declaration.Generator.Internals.DeclarationTypes.Exceptions;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;

namespace Declaration.Generator.Internals.DeclarationTypes.Bases
{
    public abstract class DifferentiatedEntity : KeyedEntity, ITypeable
    {
        public DifferentiatedEntity() : base() { }
        public DifferentiatedEntity(in string block, in string layer, in string type, in string @namespace = default, in byte? keySize = default) : base(keySize)
        {
            BlockName = block;
            LayerName = layer;
            Namespace = @namespace;
            Type = type;
        }
        public string BlockName { get; set; }
        public string LayerName { get; set; }
        public string Namespace { get; set; }
        public string Type { get; set; }

        public TypeName GetTypeName()
            => string.IsNullOrWhiteSpace(Type) ? throw new TypeNameNotProvidedException()
            : !string.IsNullOrWhiteSpace(Namespace) ? new TypeName(Namespace, Type)
            : !string.IsNullOrWhiteSpace(BlockName) && !string.IsNullOrWhiteSpace(LayerName)
            ? new TypeName(string.Concat("Model.", BlockName, ".", LayerName), Type)
            : throw new NamespaceNotInferrableException();
    }
}
