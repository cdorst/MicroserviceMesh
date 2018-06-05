using System.Data.HashFunction.xxHash;
using static System.Data.HashFunction.xxHash.xxHashFactory;
using static System.Text.Encoding;

namespace Measurements
{
    internal static class XxHashMeasurements
    {
        private static byte[] _stringBytes = UTF8.GetBytes("Hello World!");

        public static int XxHash32HashLength() => GetHashLength(32);

        public static int XxHash64HashLength() => GetHashLength(64);

        private static int GetHashLength(in int size)
            => Instance.Create(new xxHashConfig { HashSizeInBits = size }).ComputeHash(_stringBytes).Hash.Length;
    }
}
