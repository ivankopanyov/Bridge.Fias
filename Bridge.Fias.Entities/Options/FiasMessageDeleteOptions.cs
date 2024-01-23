using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasMessageDelete"/></summary>
    [FiasOptions(typeof(FiasMessageDelete))]
    public class FiasMessageDeleteOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasMessageDelete.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasMessageDelete.MessageId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MessageId))]
        public bool MessageId => true;

        /// <summary>Use <see cref="FiasMessageDelete.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasMessageDelete.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

