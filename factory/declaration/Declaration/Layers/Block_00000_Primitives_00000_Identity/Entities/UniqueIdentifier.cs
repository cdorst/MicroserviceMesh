// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using static Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities;
using static Declaration.Layers.Block_00000_Primitives_00000_Identity.Constants;

namespace Declaration.Layers.Block_00000_Primitives_00000_Identity
{
    /// <summary>Contains declaration describing UniqueIdentifier entity types</summary>
    public static class UniqueIdentifier
    {
        /// <summary>Contains declaration representing this entity type</summary>
        public static readonly Entity Declaration = Entity(BlockName, LayerName, nameof(UniqueIdentifier), default);
    }
}
