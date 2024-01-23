using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasDatabaseResyncEnd"/></summary>
    [FiasOptions(typeof(FiasDatabaseResyncEnd))]
    public class FiasDatabaseResyncEndOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasDatabaseResyncEnd.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;
    }
}
