using Declaration.Generator.Internals.DeclarationTypes;
using System.Collections.Generic;

namespace Declaration.Generator.Internals
{
    public class DeclarationRoot
    {
        public DeclarationRoot(in IEnumerable<Layer> layers) => Layers = layers;

        public IEnumerable<Layer> Layers { get; set; }

        public Queue<Layer> GetLayerStackAsQueue()
            => new Queue<Layer>(Layers);
    }
}
