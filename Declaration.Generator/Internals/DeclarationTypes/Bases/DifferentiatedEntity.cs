using Declaration.Generator.Internals.DeclarationTypes.Exceptions;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;

namespace Declaration.Generator.Internals.DeclarationTypes.Bases
{
    public abstract class DifferentiatedEntity : NamedTypeKeyedEntity, ITypeable
    {
        public DifferentiatedEntity() : base() { }
        public DifferentiatedEntity(in string type,
            in string block = default,
            in string layer = default,
            in string @namespace = default,
            in byte? keySize = default)
            : base(in type, in @namespace, in keySize)
        {
            BlockName = block;
            LayerName = layer;
        }
        public string BlockName { get; set; }
        public string LayerName { get; set; }

        public TypeName GetTypeName()
            => string.IsNullOrWhiteSpace(Type) ? throw new TypeNameNotProvidedException()
            : !string.IsNullOrWhiteSpace(Namespace) ? new TypeName(Namespace, Type)
            : !string.IsNullOrWhiteSpace(BlockName) && !string.IsNullOrWhiteSpace(LayerName)
            ? new TypeName(string.Concat("Model.", BlockName, ".", LayerName), Type)
            : throw new NamespaceNotInferrableException();
    }
}
