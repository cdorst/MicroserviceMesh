using Declaration.Generator.Internals.DeclarationTypes.Exceptions;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;

namespace Declaration.Generator.Internals.DeclarationTypes.Bases
{
    public abstract class DifferentiatedEntity : KeyedEntity, ITypeable
    {
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
