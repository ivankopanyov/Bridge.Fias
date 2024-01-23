using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasKeyDelete"/></summary>
    [FiasOptions(typeof(FiasKeyDelete))]
    public class FiasKeyDeleteOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasKeyDelete.KeyCoder"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyCoder))]
        public bool KeyCoder => true;

        /// <summary>Use <see cref="FiasKeyDelete.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasKeyDelete.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasKeyDelete.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasKeyDelete.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }

        /// <summary>Use <see cref="FiasKeyDelete.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasKeyDelete.UseKeyAnswerTrack3Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RequestType))]
        public bool UseKeyAnswerTrack3Data { get; set; }

        /// <summary>Use <see cref="FiasKeyDelete.SuiteInfo"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SuiteInfo))]
        public bool SuiteInfo { get; set; }
    }
}

