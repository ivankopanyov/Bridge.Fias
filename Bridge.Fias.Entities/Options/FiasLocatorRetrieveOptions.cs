using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// Options for <see cref="FiasLocatorRetrieveRequest"/>
    /// and <see cref="FiasLocatorRetrieveResponse"/>
    /// </summary>
    [FiasOptions(typeof(FiasLocatorRetrieveRequest))]
    public class FiasLocatorRetrieveOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasLocatorRetrieveResponse.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasLocatorRetrieveResponse.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>
        /// Use <see cref="FiasLocatorRetrieveRequest.ReservationNumber"/>
        /// and <see cref="FiasLocatorRetrieveResponse.ReservationNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasLocatorRetrieveResponse.LocatorExpiryTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.LocatorExpiryTime))]
        public bool LocatorExpiryTime => true;

        /// <summary>
        /// Use <see cref="FiasLocatorRetrieveRequest.DateTime"/>
        /// and <see cref="FiasLocatorRetrieveResponse.DateTime"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>
        /// Use <see cref="FiasLocatorRetrieveRequest.RoomNumber"/>
        /// and <see cref="FiasLocatorRetrieveResponse.RoomNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber { get; set; }
    }
}

