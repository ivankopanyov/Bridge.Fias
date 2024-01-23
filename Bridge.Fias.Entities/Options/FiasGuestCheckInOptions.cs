using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasGuestCheckIn"/></summary>
    [FiasOptions(typeof(FiasGuestCheckIn))]
    public class FiasGuestCheckInOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasGuestCheckIn.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasGuestCheckIn.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasGuestCheckIn.ShareFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ShareFlag))]
        public bool ShareFlag => true;

        /// <summary>Use <see cref="FiasGuestCheckIn.UserDefinableFields"/></summary>
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

        /// <summary>Use <see cref="FiasGuestCheckIn.ClassOfService"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClassOfService))]
        public bool ClassOfService { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.ProfileNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ProfileNumber))]
        public bool ProfileNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestArrivalDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestArrivalDate))]
        public bool GuestArrivalDate { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestDepartureDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestDepartureDate))]
        public bool GuestDepartureDate { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestFirstName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestFirstName))]
        public bool GuestFirstName { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestGroupNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestGroupNumber))]
        public bool GuestGroupNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestLanguage"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestLanguage))]
        public bool GuestLanguage { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestTitle"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestTitle))]
        public bool GuestTitle { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.GuestVipStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestVipStatus))]
        public bool GuestVipStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.MinibarRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MinibarRights))]
        public bool MinibarRights { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.NoPostStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.NoPostStatus))]
        public bool NoPostStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.ShareFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SwapFlag))]
        public bool SwapFlag { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.TVRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TVRights))]
        public bool TVRights { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.VideoRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.VideoRights))]
        public bool VideoRights { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.EquipmentNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentNumber))]
        public bool EquipmentNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.EquipmentStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentStatus))]
        public bool EquipmentStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckIn.PoolId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PoolId))]
        public bool PoolId { get; set; }
    }
}

