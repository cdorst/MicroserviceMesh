using Declaration.Generator.Internals.DeclarationTypes.Bases;
using Declaration.Generator.Internals.DeclarationTypes.Exceptions;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Entity : DifferentiatedEntity
    {
        public Entity() { }
        public Entity(in string block, in string layer, in string type, in Value value)
            : base(in block, in layer, in type)
        {
            Value = value;
        }
        public Entity(in string block, in string layer, in string type, in string valueType, in string valueNamespace = default)
            : this(in block, in layer, in type, new Value(in valueType, in valueNamespace))
        {
        }
        public Entity(in string block, in string layer, in string type, in string valueType, in Attributes attributes, in string valueNamespace = default)
            : this(in block, in layer, in type, new Value(in valueType, in attributes, in valueNamespace))
        {
        }
        public Entity(in string block, in string layer, in string type, in string valueType, in ShadowAlternateKey alternateKey, in Attributes attributes = default, in string valueNamespace = default)
            : this(in block, in layer, in type, new Value(in valueType, in alternateKey, in attributes, in valueNamespace))
        {
        }

        public List<Hierarchy> Hierarchies { get; set; }
        public List<Label> Labels { get; set; }
        public Reference Reference { get; set; }
        public Value Value { get; set; }

        public Kind GetElementKind() =>
            Reference == null && Value != null ? Kind.Datum
            : Value == null && Reference != null ? Kind.DatumLabel
            : Value != null && Reference != null ? Kind.HierarchyAttribute
            : Labels != null || Hierarchies != null ? Kind.Hierarchy
            : throw new KindNotInferrableException();
    }
}
