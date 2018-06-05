using static Measurements.XxHashMeasurements;
using static System.Console;
using static System.String;

namespace Measurements
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine(Concat("xxHash 32-bit byte[] length: ", XxHash32HashLength())); // 4
            WriteLine(Concat("xxHash 64-bit byte[] length: ", XxHash64HashLength())); // 8
        }
    }
}
