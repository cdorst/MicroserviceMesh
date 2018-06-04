﻿using Declaration.Generator.Internals.DeclarationTypes.Bases;
using Declaration.Generator.Internals.DeclarationTypes.Exceptions;
using Declaration.Generator.Internals.DeclarationTypes.ValueTypes;
using System.Collections.Generic;

namespace Declaration.Generator.Internals.DeclarationTypes
{
    public class Entity : DifferentiatedEntity
    {
        public Entity() { }
        public Entity(in string block, in string layer, in string type, in string @namespace = default)
        {
            BlockName = block;
            LayerName = layer;
            Namespace = @namespace;
            Type = type;
        }
        public Entity(in string block, in string layer, in string type, in Value value)
            : this(in block, in layer, in type)
        {
            Value = value;
        }

        public List<Hierarchy> Hierarchies { get; set; }
        public List<Label> Labels { get; set; }
        public Reference Reference { get; set; }
        public Value Value { get; set; }

        public Kind GetElementKind() =>
            Reference == null && Value != null ? Kind.Datum
            : Value == null && Reference != null ? Kind.DatumLabel
            : Value != null && Reference != null ? Kind.HierarchyAttribute
            : Labels != null || Hierarchies != null ? Kind.Hierarchy
            : throw new KindNotInferrableException();
    }
}
