using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasKeyRequest"/></summary>
    [FiasOptions(typeof(FiasKeyRequest))]
    public class FiasKeyRequestOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasKeyRequest.KeyCoder"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyCoder))]
        public bool KeyCoder => true;

        /// <summary>Use <see cref="FiasKeyRequest.KeyType"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyType))]
        public bool KeyType => true;

        /// <summary>Use <see cref="FiasKeyRequest.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasKeyRequest.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasKeyRequest.Track1Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track1Data))]
        public bool Track1Data { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.Track2Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track2Data))]
        public bool Track2Data { get; set; }

        /// <summary>Use in <see cref="FiasKeyRequest.UserDefinableFields"/></summary>
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

        /// <summary>Use <see cref="FiasKeyRequest.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.DateTimeOptional"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.DepartureTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DepartureTime))]
        public bool DepartureTime { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.GuestArrivalDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestArrivalDate))]
        public bool GuestArrivalDate { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.GuestDepartureDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestDepartureDate))]
        public bool GuestDepartureDate { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.GuestGroupNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestGroupNumber))]
        public bool GuestGroupNumber { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.KeyCount"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyCount))]
        public bool KeyCount { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.KeyOptions"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyOptions))]
        public bool KeyOptions { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.UseKeyAnswerTrack3Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RequestType))]
        public bool UseKeyAnswerTrack3Data { get; set; }

        /// <summary>Use <see cref="FiasKeyRequest.SuiteInfoCollection"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SuiteInfo))]
        public bool SuiteInfoCollection { get; set; }
    }
}

