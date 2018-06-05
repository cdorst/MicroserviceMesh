// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using static Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities;
using static Declaration.Layers.Block_00000_Primitives_00001_Integers.Constants;

namespace Declaration.Layers.Block_00000_Primitives_00001_Integers
{
    /// <summary>Contains declaration describing Integer64 entity types</summary>
    public static class Integer64
    {
        /// <summary>Contains declaration representing this entity type</summary>
        public static readonly Entity Declaration = Entity(BlockName, LayerName, nameof(Integer64), "Int64", "System");
    }
}
