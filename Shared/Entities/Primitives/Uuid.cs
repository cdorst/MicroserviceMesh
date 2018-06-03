using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Entities.Primitives
{
    [Table(nameof(Uuid), Schema = nameof(Primitives))]
    public class Uuid : IDatum<Uuid, long, Guid>
    {
        public Uuid() => Value = Guid.NewGuid();
        public long Id { get; set; }
        public Guid Value { get; set; }

        public bool Equals(Uuid other) => this.Equate<Uuid, long>(other);
        public bool EqualsWithKey(in Uuid other) => this.EquateWithKey<Uuid, long>(in other);

        public ReadOnlyMemory<byte> ToReadOnlyMemory() => Value.ToByteArray();
        public ReadOnlySpan<byte> ToReadOnlySpan() => Value.ToByteArray();
    }
}
