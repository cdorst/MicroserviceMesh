using Declaration.Generator.Types.Bases;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Types.Exceptions
{
    [Serializable]
    public class NamespaceNotInferrableException : Exception
    {
        public NamespaceNotInferrableException() : base($"The type namespace could not be inferred from the {nameof(TypedKeyedElement.BlockName)}, {nameof(TypedKeyedElement.FamilyName)}, and {nameof(TypedKeyedElement.Namespace)} values provided. Please provide (explicitly or infer/compute and assign) the {nameof(TypedKeyedElement.BlockName)} and {nameof(TypedKeyedElement.FamilyName)} values for declaration-declared types - these will be concatenated into a namespace value of `Model.{{{nameof(TypedKeyedElement.BlockName)}}}.{{{nameof(TypedKeyedElement.FamilyName)}}}` by the {nameof(TypedKeyedElement.GetTypeName)} method. Provide the {nameof(TypedKeyedElement.Namespace)}` value for system, SQL database-savable, datum primitive types (e.g. \"System\" for System.Guid, System.Int32, or System.DateTimeOffset).") { }
        public NamespaceNotInferrableException(string message)
            : base(message) { }
        public NamespaceNotInferrableException(string message, Exception inner) : base(message, inner) { }
        protected NamespaceNotInferrableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
