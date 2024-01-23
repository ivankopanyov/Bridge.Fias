using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasVirtualNumberNotification"/></summary>
    [FiasOptions(typeof(FiasVirtualNumberNotification))]
    public class FiasVirtualNumberNotificationOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasVirtualNumberNotification.EquipmentNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentNumber))]
        public bool EquipmentNumber => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.EquipmentStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentStatus))]
        public bool EquipmentStatus => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.PoolId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PoolId))]
        public bool PoolId => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasVirtualNumberNotification.GuestPin"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomStatus))]
        public bool GuestPin { get; set; }
    }
}

