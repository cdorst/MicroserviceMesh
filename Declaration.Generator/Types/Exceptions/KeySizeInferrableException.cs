using Declaration.Generator.Types.Bases;
using Declaration.Generator.Types.Validation;
using Declaration.Generator.Types.ValueTypes;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Types.Exceptions
{
    [Serializable]
    public class KeySizeNotInferrableException : Exception
    {
        public KeySizeNotInferrableException() : base($"The key size could not be inferred from the {nameof(KeyedElement.KeySize)} value provided. Please describe whether your element uses an Int8, Int16, Int32, or Int64 by providing the value 8, 16, 32, or 64 respectively. Leave the {nameof(KeyedElement.KeySize)} property blank (null) to infer a {nameof(KeySize)} value of {DefaultValues.KeySize}") { }
        public KeySizeNotInferrableException(string message)
            : base(message) { }
        public KeySizeNotInferrableException(string message, Exception inner) : base(message, inner) { }
        protected KeySizeNotInferrableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
