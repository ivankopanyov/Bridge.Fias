using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasMessageText"/></summary>
    [FiasOptions(typeof(FiasMessageText))]
    public class FiasMessageTextOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasMessageText.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasMessageText.MessageId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MessageId))]
        public bool MessageId => true;

        /// <summary>Use <see cref="FiasMessageText.MessageText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MessageText))]
        public bool MessageText => true;

        /// <summary>Use <see cref="FiasMessageText.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasMessageText.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

