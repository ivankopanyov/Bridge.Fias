using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// Options for <see cref="FiasRemoteCheckOutRequest"/>
    /// and <see cref="FiasRemoteCheckOutResponse"/>
    /// </summary>
    [FiasOptions(typeof(FiasRemoteCheckOutRequest))]
    public class FiasRemoteCheckOutOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasRemoteCheckOutResponse.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>
        /// Use <see cref="FiasRemoteCheckOutRequest.BalanceAmount"/>
        /// and <see cref="FiasRemoteCheckOutResponse.BalanceAmount"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.BalanceAmount))]
        public bool BalanceAmount => true;

        /// <summary>Use <see cref="FiasRemoteCheckOutResponse.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>
        /// Use <see cref="FiasRemoteCheckOutRequest.ReservationNumber"/>
        /// and <see cref="FiasRemoteCheckOutResponse.ReservationNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>
        /// Use <see cref="FiasRemoteCheckOutRequest.RoomNumber"/>
        /// and <see cref="FiasRemoteCheckOutResponse.RoomNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>
        /// Use <see cref="FiasRemoteCheckOutRequest.DateTime"/>
        /// and <see cref="FiasRemoteCheckOutResponse.DateTime"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

