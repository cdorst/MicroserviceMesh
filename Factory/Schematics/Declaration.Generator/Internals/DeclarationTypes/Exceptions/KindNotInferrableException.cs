using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Internals.DeclarationTypes.Exceptions
{
    [Serializable]
    public class KindNotInferrableException : Exception
    {
        public KindNotInferrableException() : base($"The kind of element being described cannot be inferred from the information provided. Please populate the {nameof(Entity.Value)} property when describing {Kind.Datum} elements. Populate the {nameof(Entity.Data)} property when describing {Kind.DatumLabel} elements. Populate both {nameof(Entity.Data)} and {nameof(Entity.Value)} properties when describing {nameof(Kind.HierarchyAttribute)} elements. Populate either one or both of the {nameof(Entity.Labels)} or {nameof(Entity.Hierarchies)} properties when describing {nameof(Kind.Hierarchy)} elemets.") { }
        public KindNotInferrableException(string message)
            : base(message) { }
        public KindNotInferrableException(string message, Exception inner) : base(message, inner) { }
        protected KindNotInferrableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
