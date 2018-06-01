using Declaration.Generator.Types;
using System;

namespace Declaration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var block in Code.Blocks)
                foreach (var family in block.Families)
                    foreach (var element in family.Elements)
                        WriteFile(in element);
        }

        public static void WriteFile(in Element element)
            => throw new NotImplementedException();
    }
}
