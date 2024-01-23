using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasWakeupRequest"/></summary>
    [FiasOptions(typeof(FiasWakeupRequest))]
    public class FiasWakeupRequestOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasWakeupRequest.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;

        /// <summary>Use <see cref="FiasWakeupRequest.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;
    }
}

