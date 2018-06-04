using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Block
    {
        public List<Layer> Layers { get; set; }
        public byte Position { get; set; }
    }
}
