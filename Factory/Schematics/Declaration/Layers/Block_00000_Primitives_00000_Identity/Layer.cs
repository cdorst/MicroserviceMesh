// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using System.Collections.Generic;

namespace Declaration.Layers.Block_00000_Primitives_00000_Identity
{
    /// <summary>Responsible for enumerating constituent Entity types</summary>
    public static class Layer
    {
        /// <summary>Returns this Layer's Entity declarations</summary>
        public static IEnumerable<Entity> GetEntities()
        {
            yield return Uuid.Declaration;
            yield return UniqueIdentifier.Declaration;
            yield return Agent.Declaration;
        }
    }
}
