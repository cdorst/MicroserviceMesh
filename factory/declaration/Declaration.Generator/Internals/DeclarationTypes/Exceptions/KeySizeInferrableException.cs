using Declaration.Generator.Internals.DeclarationTypes.Bases;
using Declaration.Generator.Internals.DeclarationTypes.Validation;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Internals.DeclarationTypes.Exceptions
{
    [Serializable]
    public class KeySizeNotInferrableException : Exception
    {
        public KeySizeNotInferrableException() : base($"The key size could not be inferred from the {nameof(KeyedEntity.KeySize)} value provided. Describe whether the entity uses an Int8, Int16, Int32, or Int64 by providing the value 8, 16, 32, or 64 respectively. Leave the {nameof(KeyedEntity.KeySize)} property blank (null) to infer a {nameof(KeySize)} value of {DefaultValues.KeySize}") { }
        public KeySizeNotInferrableException(string message)
            : base(message) { }
        public KeySizeNotInferrableException(string message, Exception inner) : base(message, inner) { }
        protected KeySizeNotInferrableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
