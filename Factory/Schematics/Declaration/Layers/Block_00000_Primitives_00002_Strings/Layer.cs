// Copyright © 2018 Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Declaration.Generator.Internals.DeclarationTypes;
using System.Collections.Generic;

namespace Declaration.Layers.Block_00000_Primitives_00002_Strings
{
    /// <summary>Responsible for enumerating constituent Entity types</summary>
    public static class Layer
    {
        /// <summary>Returns this Layer's Entity declarations</summary>
        public static IEnumerable<Entity> GetEntities()
        {
            yield return StringAscii900.Declaration;
            yield return StringAsciiMax.Declaration;
            yield return StringHash.Declaration;
            yield return StringUnicode450.Declaration;
            yield return StringUnicodeMax.Declaration;
        }
    }
}
