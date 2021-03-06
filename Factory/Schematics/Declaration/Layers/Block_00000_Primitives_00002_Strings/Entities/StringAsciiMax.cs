// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using static Declaration.Generator.Internals.DeclarationTypes.Helpers.Entities;
using static Declaration.Generator.Internals.DeclarationTypes.Helpers.ValueAttributes;
using static Declaration.Layers.Block_00000_Primitives_00002_Strings.Constants;

namespace Declaration.Layers.Block_00000_Primitives_00002_Strings
{
    /// <summary>Contains declaration describing StringAsciiMax entity types</summary>
    public static class StringAsciiMax
    {
        /// <summary>Contains declaration representing this entity type</summary>
        public static readonly Entity Declaration = Entity(BlockName, LayerName, nameof(StringAsciiMax), valueType: "String", valueNamespace: "System", attributes: Attributes(columnType: "varchar(max)"), keySize: 32);
    }
}
