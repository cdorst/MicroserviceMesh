using Declaration.Generator.Types.ValueTypes;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Types.Exceptions
{
    [Serializable]
    public class KindNotInferrableException : Exception
    {
        public KindNotInferrableException() : base($"The kind of element being described cannot be inferred from the information provided. Please populate the {nameof(Element.Value)} property when describing {Kind.Datum} elements. Populate the {nameof(Element.Reference)} property when describing {Kind.DatumLabel} elements. Populate both {nameof(Element.Reference)} and {nameof(Element.Value)} properties when describing {nameof(Kind.HierarchyAttribute)} elements. Populate either one or both of the {nameof(Element.Labels)} or {nameof(Element.Hierarchies)} properties when describing {nameof(Kind.Hierarchy)} elemets.") { }
        public KindNotInferrableException(string message)
            : base(message) { }
        public KindNotInferrableException(string message, Exception inner) : base(message, inner) { }
        protected KindNotInferrableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
