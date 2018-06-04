using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Layer
    {
        public List<Entity> Entities { get; set; }
        public short Position { get; set; }
        public byte RankOrderOffset { get; set; }

        public string Name { get; set; }
        public string BlockName { get; set; }
    }
}
