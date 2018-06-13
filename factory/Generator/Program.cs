using static Declaration.Root;

namespace Generator
{
    public static class Program
    {
        public static void Main(string[] args = default)
        {
            var declaration = GetDeclaration();
            foreach (var layer in declaration)
            {
                // TODO: Add layer to DbContext stack
                // TODO: Add Save-operation microservice
            }
        }
    }
}
