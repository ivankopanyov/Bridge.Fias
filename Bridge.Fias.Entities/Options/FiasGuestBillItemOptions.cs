using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasGuestBillItem"/></summary>
    [FiasOptions(typeof(FiasGuestBillItem))]
    public class FiasGuestBillItemOptions
    {
        /// <summary>Use <see cref="FiasGuestBillItem.ItemDescription"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ItemDescription))]
        public bool ItemDescription => true;

        /// <summary>Use <see cref="FiasGuestBillItem.ItemAmount"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ItemAmount))]
        public bool ItemAmount => true;

        /// <summary>Use <see cref="FiasGuestBillItem.DepartmentCode"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DepartmentCode))]
        public bool DepartmentCode => true;

        /// <summary>Use <see cref="FiasGuestBillItem.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasGuestBillItem.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasGuestBillItem.FolioNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.FolioNumber))]
        public bool FolioNumber => true;

        /// <summary>Use <see cref="FiasGuestBillItem.ItemDisplayFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ItemDisplayFlag))]
        public bool ItemDisplayFlag => true;

        /// <summary>Use <see cref="FiasGuestBillItem.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

