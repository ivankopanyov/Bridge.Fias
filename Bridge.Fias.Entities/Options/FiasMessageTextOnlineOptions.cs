using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// Options for <see cref="FiasMessageTextOnlineRequest"/>
    /// and <see cref="FiasMessageTextOnlineResponse"/>
    /// </summary>
    [FiasOptions(typeof(FiasMessageTextOnlineRequest))]
    public class FiasMessageTextOnlineOptions : FiasOptions
    {
        /// <summary>
        /// Use <see cref="FiasMessageTextOnlineRequest.ReservationNumber"/>
        /// and <see cref="FiasMessageTextOnlineResponse.ReservationNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasMessageTextOnlineResponse.MessageId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MessageId))]
        public bool MessageId => true;

        /// <summary>
        /// Use <see cref="FiasMessageTextOnlineRequest.MessageText"/>
        /// and <see cref="FiasMessageTextOnlineResponse.MessageText"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.MessageText))]
        public bool MessageText => true;

        /// <summary>
        /// Use <see cref="FiasMessageTextOnlineRequest.RoomNumber"/>
        /// and <see cref="FiasMessageTextOnlineResponse.RoomNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasMessageTextOnlineRequest.ExternalMessageId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ExternalMessageId))]
        public bool ExternalMessageId { get; set; }

        /// <summary>
        /// Use <see cref="FiasMessageTextOnlineRequest.DateTime"/>
        /// and <see cref="FiasMessageTextOnlineResponse.DateTime"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

