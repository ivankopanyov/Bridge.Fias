using Bridge.Fias.Entities.Base;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasRoomEquipmentStatusResponse"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasRoomEquipmentStatusOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasRoomEquipmentStatusResponse"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasRoomEquipmentStatusOptions"/>.
    /// </summary>
    public partial class FiasRoomEquipmentStatusResponse : FiasMessageFromPms
    {
        public string RoomNumber { get; set; }

        /// <summary>
        /// Required only if line COS (bar/unbar) functionality is available and used.<br/>
        /// Требуется только в том случае, если функция COS линии (запрет/снятие блокировки)
        /// доступна и используется.
        /// </summary>
        public FiasClassesOfService? ClassOfService { get; set; }

        public bool? DoNotDisturb { get; set; }

        /// <summary>
        /// Required only if Message Lamp functionality is available and used guest based
        /// (i.e., <see cref="FiasGuestCheckIn.ReservationNumber"/> is used too) - typically
        /// used as notification for a text message; only use this if Extended Guest Data messages are supported.<br/>
        /// Требуется только в том случае, если функция Message Lamp доступна и используется гостем
        /// (т. е. <see cref="FiasGuestCheckIn.ReservationNumber"/> также используется) — обычно
        /// используется в качестве уведомления о текстовом сообщении; использовать только
        /// это если поддерживаются сообщения расширенных гостевых данных.
        /// </summary>
        public long? ReservationNumber { get; set; }

        /// <summary>
        /// Required only if Message Lamp functionality is available and used guest based
        /// (i.e., <see cref="FiasGuestCheckIn.ReservationNumber"/> is used too) - typically
        /// used as notification for a text message; only use this if Extended Guest Data messages are supported.<br/>
        /// Требуется только в том случае, если функция Message Lamp доступна и используется гостем
        /// (т. е. <see cref="FiasGuestCheckIn.ReservationNumber"/> также используется) — обычно
        /// используется в качестве уведомления о текстовом сообщении; использовать только
        /// это если поддерживаются сообщения расширенных гостевых данных.
        /// </summary>
        public bool? MessageLightStatus { get; set; }

        /// <summary>
        /// Required only if Minibar functionality is available and used.<br/>
        /// Требуется только в том случае, если функциональность мини-бара доступна и используется.
        /// </summary>
        public FiasMinibarRights? MinibarRights { get; set; }

        /// <summary>
        /// Required only if TV Rights functionality is available and used.<br/>
        /// Требуется только в том случае, если функция TV Rights доступна и используется.
        /// </summary>
        public FiasTVRights? TVRights { get; set; }

        public FiasRoomMaidStatuses? RoomStatus { get; set; }
    }
}

