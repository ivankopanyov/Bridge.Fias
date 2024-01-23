using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Bridge.Fias.Entities.Base
{
    public abstract class FiasMessageToPms : FiasMessageBase
    {
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            => Enumerable.Empty<ValidationResult>();
    }
}