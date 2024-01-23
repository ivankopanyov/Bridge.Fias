using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasGuestBillBalance"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasGuestBillBalanceOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasGuestBillBalance"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasGuestBillBalanceOptions"/>.
    /// </summary>
    public partial class FiasGuestBillBalance : FiasMessageFromPms
    {
        public decimal BalanceAmount { get; set; }

        public long ReservationNumber { get; set; }

        public string RoomNumber { get; set; }

        public FiasAnswerStatuses AnswerStatus { get; set; }

        public DateTime? DateTime { get; set; }
    }
}

