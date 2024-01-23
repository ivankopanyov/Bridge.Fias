using System;

namespace Bridge.Fias.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    internal class FiasForAttribute : Attribute
    {
        public string Name { get; private set; }

        public FiasForAttribute(string name) => Name = name;
    }
}