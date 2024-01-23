using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasKeyDataChange"/></summary>
    [FiasOptions(typeof(FiasKeyDataChange))]
    public class FiasKeyDataChangeOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasKeyDataChange.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasKeyDataChange.KeyCoder"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyCoder))]
        public bool KeyCoder => true;

        /// <summary>Use <see cref="FiasKeyDataChange.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasKeyDataChange.OldRoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.OldRoomNumber))]
        public bool OldRoomNumber => true;

        /// <summary>Use <see cref="FiasKeyDataChange.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasKeyDataChange.Track1Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track1Data))]
        public bool Track1Data { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.Track2Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track2Data))]
        public bool Track2Data { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.UserDefinableFields"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField0))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField1))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField2))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField3))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField4))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField5))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField6))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField7))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField8))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField9))]
        public bool UserDefinableFields { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.DateTimeOptional"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.DepartureTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DepartureTime))]
        public bool DepartureTime { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.GuestArrivalDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestArrivalDate))]
        public bool GuestArrivalDate { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.GuestDepartureDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestDepartureDate))]
        public bool GuestDepartureDate { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.GuestGroupNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestGroupNumber))]
        public bool GuestGroupNumber { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.UseKeyAnswerTrack3Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RequestType))]
        public bool UseKeyAnswerTrack3Data { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.SuiteInfo"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SuiteInfo))]
        public bool SuiteInfo { get; set; }

        /// <summary>Use <see cref="FiasKeyDataChange.SuiteInformationOfOldRoom"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SuiteInformationOfOldRoom))]
        public bool SuiteInformationOfOldRoom { get; set; }
    }
}
