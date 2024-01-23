using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasNightAuditStart"/></summary>
    [FiasOptions(typeof(FiasNightAuditStart))]
    public class FiasNightAuditStartOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasNightAuditStart.DateTime"/></summary>[FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;
    }
}

