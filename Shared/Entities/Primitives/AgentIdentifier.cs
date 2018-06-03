using Common.Extensions.Memory;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities.Primitives
{
    [Table(nameof(AgentIdentifier), Schema = nameof(Primitives))]
    public class AgentIdentifier : IDatumLabel<AgentIdentifier, long, Uuid, long, Guid>
    {
        public long Id { get; set; }

        public Uuid Datum { get; set; }
        public long DatumId { get; set; }

        public bool Equals(AgentIdentifier other) => this.Equate<AgentIdentifier, long>(other);
        public bool EqualsWithKey(in AgentIdentifier other) => this.EquateWithKey<AgentIdentifier, long>(other);

        public ReadOnlyMemory<byte> ToReadOnlyMemory() => DatumId.ToMemory();
        public ReadOnlySpan<byte> ToReadOnlySpan() => DatumId.ToSpan();
    }
}
