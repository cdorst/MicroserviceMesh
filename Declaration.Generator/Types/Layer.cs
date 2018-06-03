using System.Collections.Generic;

namespace Declaration.Generator.Types
{
    public class Layer
    {
        public List<Element> Elements { get; set; }
        public short Position { get; set; }
        public byte RankOrderOffset { get; set; }

        public string Name { get; set; }
        public string BlockName { get; set; }
    }
}
