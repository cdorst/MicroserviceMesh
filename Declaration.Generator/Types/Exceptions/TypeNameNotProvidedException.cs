using Declaration.Generator.Types.Bases;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Types.Exceptions
{
    [Serializable]
    public class TypeNameNotProvidedException : Exception
    {
        public TypeNameNotProvidedException() : base($"The type name \"{nameof(DifferentiatedEntity.Type)}\" property was found to be null or whitespace-only. Please provide a type name value.") { }
        public TypeNameNotProvidedException(string message)
            : base(message) { }
        public TypeNameNotProvidedException(string message, Exception inner) : base(message, inner) { }
        protected TypeNameNotProvidedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
