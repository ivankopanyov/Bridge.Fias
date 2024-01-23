using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasWakeupClear"/></summary>
    [FiasOptions(typeof(FiasWakeupClear))]
    public class FiasWakeupClearOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasWakeupClear.DateTimeOptional"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasWakeupClear.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber { get; set; }
    }
}

