// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using System.Collections.Generic;

namespace Declaration
{
    /// <summary>Responsible for enumerating constituent Entity types</summary>
    public static class Root
    {
        /// <summary>Returns enumeration of Entity Layers</summary>
        public static IEnumerable<IEnumerable<Entity>> GetDeclaration()
        {
            yield return Layers.Block_00000_Primitives_00000_Identity.Layer.GetEntities();
            yield return Layers.Block_00000_Primitives_00001_Integers.Layer.GetEntities();
            yield return Layers.Block_00000_Primitives_00002_Strings.Layer.GetEntities();
        }
    }
}
