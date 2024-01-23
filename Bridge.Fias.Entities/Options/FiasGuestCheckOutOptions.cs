using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasGuestCheckOut"/></summary>
    [FiasOptions(typeof(FiasGuestCheckOut))]
    public class FiasGuestCheckOutOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasGuestCheckOut.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasGuestCheckOut.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasGuestCheckOut.ShareFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ShareFlag))]
        public bool ShareFlag => true;

        /// <summary>Use <see cref="FiasGuestCheckOut.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.SwapFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SwapFlag))]
        public bool SwapFlag { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.EquipmentNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentNumber))]
        public bool EquipmentNumber { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.EquipmentStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentStatus))]
        public bool EquipmentStatus { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.PoolId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PoolId))]
        public bool PoolId { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.EquipmentNumberOfSourceRoom"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentNumberOfSourceRoom))]
        public bool EquipmentNumberOfSourceRoom { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.EquipmentStatusOfSourceRoom"/></summary>
        [FiasFor(nameof(FiasCommonMessage.EquipmentStatusOfSourceRoom))]
        public bool EquipmentStatusOfSourceRoom { get; set; }

        /// <summary>Use <see cref="FiasGuestCheckOut.PoolIdOfSourceRoom"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PoolIdOfSourceRoom))]
        public bool PoolIdOfSourceRoom { get; set; }
    }
}
