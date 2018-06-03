using Declaration.Generator.Types.Bases;
using System;
using System.Runtime.Serialization;

namespace Declaration.Generator.Types.Exceptions
{
    [Serializable]
    public class NamespaceNotInferrableException : Exception
    {
        public NamespaceNotInferrableException() : base($"The type namespace could not be inferred from the {nameof(DifferentiatedEntity.BlockName)}, {nameof(DifferentiatedEntity.LayerName)}, and {nameof(DifferentiatedEntity.Namespace)} values provided. Please provide (explicitly or infer/compute and assign) the {nameof(DifferentiatedEntity.BlockName)} and {nameof(DifferentiatedEntity.LayerName)} values for declaration-declared types - these will be concatenated into a namespace value of `Model.{{{nameof(DifferentiatedEntity.BlockName)}}}.{{{nameof(DifferentiatedEntity.LayerName)}}}` by the {nameof(DifferentiatedEntity.GetTypeName)} method. Provide the {nameof(DifferentiatedEntity.Namespace)}` value for system, SQL database-savable, datum primitive types (e.g. \"System\" for System.Guid, System.Int32, or System.DateTimeOffset).") { }
        public NamespaceNotInferrableException(string message)
            : base(message) { }
        public NamespaceNotInferrableException(string message, Exception inner) : base(message, inner) { }
        protected NamespaceNotInferrableException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
