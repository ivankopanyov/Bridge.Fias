using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasGuestBillItem"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasGuestBillItemOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasGuestBillItem"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasGuestBillItemOptions"/>.
    /// </summary>
    public partial class FiasGuestBillItem : FiasMessageFromPms
    {
        public string ItemDescription { get; set; }

        public decimal ItemAmount { get; set; }

        public decimal DepartmentCode { get; set; }

        public long ReservationNumber { get; set; }

        public string RoomNumber { get; set; }

        public int FolioNumber { get; set; }

        public bool ItemDisplayFlag { get; set; }

        public DateTime? DateTime { get; set; }
    }
}

