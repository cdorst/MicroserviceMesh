using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Elements.Primitives
{
    [Table(nameof(Agent), Schema = nameof(Primitives))]
    public class Agent : IDatum<Agent, long, Guid>
    {
        public Agent() => Value = Guid.NewGuid();
        public long Id { get; set; }
        public Guid Value { get; set; }

        public bool Equals(Agent other) => this.Equate<Agent, long>(other);

        public ReadOnlyMemory<byte> ToReadOnlyMemory() => Value.ToByteArray();
        public ReadOnlySpan<byte> ToReadOnlySpan() => Value.ToByteArray();
    }
}
