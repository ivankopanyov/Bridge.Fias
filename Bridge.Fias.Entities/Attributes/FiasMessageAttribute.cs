using System;

namespace Bridge.Fias.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class FiasMessageAttribute : Attribute
    {
        public string Indicator { get; private set; }

        public FiasMessageDirections Direction { get; private set; }

        public FiasMessageAttribute(string indicator, FiasMessageDirections direction)
        {
            Indicator = indicator;
            Direction = direction;
        }
    }
}