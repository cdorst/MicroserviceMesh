using Declaration.Generator.Types;
using System;
using System.Collections.Generic;

namespace Declaration
{
    public class Program
    {
        public static void Main(string[] args = default)
        {
        }

        private static IEnumerable<Layer> GetLayers()
        {
            foreach (var block in Code.Blocks)
                foreach (var layer in block.Layers)
                    yield return layer;
        }

        private static void WriteFile(in Entity entity)
            => throw new NotImplementedException();
    }
}
