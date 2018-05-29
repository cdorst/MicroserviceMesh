using System;

namespace Shared
{
    public interface IMemorySerializable
    {
        ReadOnlyMemory<byte> ToReadOnlyMemory();
        ReadOnlySpan<byte> ToReadOnlySpan();
    }
}
