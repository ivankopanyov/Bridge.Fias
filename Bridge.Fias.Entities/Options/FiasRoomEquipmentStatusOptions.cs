using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// Options for <see cref="FiasRoomEquipmentStatusRequest"/>
    /// and <see cref="FiasRoomEquipmentStatusResponse"/></summary>
    [FiasOptions(typeof(FiasRoomEquipmentStatusRequest))]
    public class FiasRoomEquipmentStatusOptions : FiasOptions
    {
        /// <summary>
        /// Use <see cref="FiasRoomEquipmentStatusRequest.RoomNumber"/>
        /// and <see cref="FiasRoomEquipmentStatusResponse.RoomNumber"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasRoomEquipmentStatusResponse.ClassOfService"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClassOfService))]
        public bool ClassOfService { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusRequest.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusResponse.DoNotDisturb"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DoNotDisturb))]
        public bool DoNotDisturb { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusResponse.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusRequest.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusResponse.MessageLightStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MessageLightStatus))]
        public bool MessageLightStatus { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusResponse.MinibarRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MinibarRights))]
        public bool MinibarRights { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusRequest.PrinterPort"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PrinterPort))]
        public bool PrinterPort { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusRequest.NumberOfPersons"/></summary>
        [FiasFor(nameof(FiasCommonMessage.NumberOfPersons))]
        public bool NumberOfPersons { get; set; }

        /// <summary>
        /// Use <see cref="FiasRoomEquipmentStatusRequest.RoomStatus"/>
        /// and <see cref="FiasRoomEquipmentStatusResponse.RoomStatus"/>
        /// </summary>
        [FiasFor(nameof(FiasCommonMessage.RoomStatus))]
        public bool RoomStatus { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusResponse.TVRights"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TVRights))]
        public bool TVRights { get; set; }

        /// <summary>Use <see cref="FiasRoomEquipmentStatusRequest.VoiceMail"/></summary>
        [FiasFor(nameof(FiasCommonMessage.VoiceMail))]
        public bool VoiceMail { get; set; }
    }
}

