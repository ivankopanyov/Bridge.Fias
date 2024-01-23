using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasNightAuditEnd"/></summary>
    [FiasOptions(typeof(FiasNightAuditEnd))]
    public class FiasNightAuditEndOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasNightAuditEnd.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;
    }
}

