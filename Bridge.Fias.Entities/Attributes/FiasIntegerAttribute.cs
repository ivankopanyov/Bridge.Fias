using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bridge.Fias.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class FiasIntegerAttribute : ValidationAttribute
    {
        private string _errorMessage;

        public override bool IsValid(object value)
        {
            if (value is null)
                return true;

            if (value is float || value is double || value is decimal)
                return IsValidNumber(value.ToString());

            if (value is IEnumerable<float> @floats)
                return IsValidEnumerable(@floats.Select(item => item.ToString()));

            if (value is IEnumerable<double> @doubles)
                return IsValidEnumerable(@doubles.Select(item => item.ToString()));

            if (value is IEnumerable<decimal> @decimals)
                return IsValidEnumerable(@decimals.Select(item => item.ToString()));

            if (value is IEnumerable<float?> @optionalFloats)
                return IsValidEnumerable(@optionalFloats.Select(item => item.ToString()));

            if (value is IEnumerable<double?> @optionalDoubles)
                return IsValidEnumerable(@optionalDoubles.Select(item => item.ToString()));

            if (value is IEnumerable<decimal?> @optionalDecimals)
                return IsValidEnumerable(@optionalDecimals.Select(item => item.ToString()));

            return true;
        }

        public override string FormatErrorMessage(string name) => $"The field {name} {_errorMessage}";

        private bool IsValidNumber(string number)
        {
            if (number.Contains('.'))
            {
                _errorMessage = "must be an integer.";
                return false;
            }

            return true;
        }

        private bool IsValidEnumerable(IEnumerable<string> numbers)
        {
            if (numbers.Any(item => item != null && item.Contains('.')))
            {
                _errorMessage = "includes a non-integer.";
                return false;
            }

            return true;
        }
    }
}