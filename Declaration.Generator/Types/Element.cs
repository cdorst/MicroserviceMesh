using Declaration.Generator.Types.Bases;
using Declaration.Generator.Types.Exceptions;
using Declaration.Generator.Types.ValueTypes;
using System.Collections.Generic;

namespace Declaration.Generator.Types
{
    public class Element : TypedKeyedElement
    {
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
