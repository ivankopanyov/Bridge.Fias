using System;

namespace Bridge.Fias.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class FiasOptionsAttribute : Attribute
    {
        public Type Type { get; private set; }

        public FiasOptionsAttribute(Type type) => Type = type;
    }
}