using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// Options for <see cref="FiasKeyReadRequest"/>
    /// and <see cref="FiasKeyReadResponse"/>
    /// </summary>
    [FiasOptions(typeof(FiasKeyReadRequest))]
    public class FiasKeyReadOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasKeyReadRequest.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasKeyReadRequest.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>
        /// Use <see cref="FiasKeyReadRequest.KeyCoder"/>
        /// and <see cref="FiasKeyReadResponse.KeyCoder"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.KeyCoder))]
        public bool KeyCoder => true;

        /// <summary>Use <see cref="FiasKeyReadRequest.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>
        /// Use <see cref="FiasKeyReadRequest.WorkStationId"/>
        /// and <see cref="FiasKeyReadResponse.WorkStationId"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>
        /// Use <see cref="FiasKeyReadRequest.DateTime"/>
        /// and <see cref="FiasKeyReadResponse.DateTime"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasKeyReadRequest.DepartureTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DepartureTime))]
        public bool DepartureTime { get; set; }

        /// <summary>Use <see cref="FiasKeyReadRequest.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasKeyReadRequest.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }

        /// <summary>Use <see cref="FiasKeyReadRequest.GuestDepartureDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestDepartureDate))]
        public bool GuestDepartureDate { get; set; }

        /// <summary>Use <see cref="FiasKeyReadRequest.KeyOptions"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyOptions))]
        public bool KeyOptions { get; set; }

        /// <summary>Use <see cref="FiasKeyReadRequest.SuiteInfo"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SuiteInfo))]
        public bool SuiteInfo { get; set; }
    }
}
