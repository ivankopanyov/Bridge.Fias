using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasGuestChange"/></summary>
    [FiasOptions(typeof(FiasGuestChange))]
    public class FiasGuestChangeOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasGuestChange.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasGuestChange.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasGuestChange.ShareFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ShareFlag))]
        public bool ShareFlag => true;

        /// <summary>Use in <see cref="FiasGuestChange.UserDefinableFields"/></summary>
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

        /// <summary>Use <see cref="FiasGuestChange.ClassOfService"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClassOfService))]
        public bool ClassOfService { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.ProfileNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ProfileNumber))]
        public bool ProfileNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestArrivalDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestArrivalDate))]
        public bool GuestArrivalDate { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestDepartureDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestDepartureDate))]
        public bool GuestDepartureDate { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestFirstName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestFirstName))]
        public bool GuestFirstName { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestGroupNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestGroupNumber))]
        public bool GuestGroupNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestLanguage"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestLanguage))]
        public bool GuestLanguage { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestTitle"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestTitle))]
        public bool GuestTitle { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.GuestVipStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestVipStatus))]
        public bool GuestVipStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.MinibarRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MinibarRights))]
        public bool MinibarRights { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.NoPostStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.NoPostStatus))]
        public bool NoPostStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.OldRoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.OldRoomNumber))]
        public bool OldRoomNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.TVRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TVRights))]
        public bool TVRights { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.VideoRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.VideoRights))]
        public bool VideoRights { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.EquipmentNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentNumber))]
        public bool EquipmentNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.EquipmentStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentStatus))]
        public bool EquipmentStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestChange.PoolId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PoolId))]
        public bool PoolId { get; set; }
    }
}

