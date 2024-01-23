using Bridge.Fias.Entities.Attributes;
using Bridge.Fias.Entities.Services.Mapping;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Bridge.Fias.Entities.Base
{
    public abstract class FiasMessageBase : IValidatableObject
    {
        private readonly string _indicator;

        public string Indicator => _indicator;

        public string Source { get; internal set; }

        public FiasMessageBase() => _indicator = GetType().GetCustomAttribute<FiasMessageAttribute>().Indicator;

        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);

        public override string ToString() => FiasMapper.Mapper.Map(this, GetType()).ToString();
    }
}
