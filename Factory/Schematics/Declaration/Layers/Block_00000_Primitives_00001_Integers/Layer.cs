// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using System.Collections.Generic;

namespace Declaration.Layers.Block_00000_Primitives_00001_Integers
{
    /// <summary>Responsible for enumerating constituent Entity types</summary>
    public static class Layer
    {
        /// <summary>Returns this Layer's Entity declarations</summary>
        public static IEnumerable<Entity> GetEntities()
        {
            yield return Integer8.Declaration;
            yield return Int8Reference.Declaration;
            yield return Integer16.Declaration;
            yield return Int16Reference.Declaration;
            yield return Integer32.Declaration;
            yield return Int32Reference.Declaration;
            yield return Integer64.Declaration;
            yield return Int64Reference.Declaration;
        }
    }
}
