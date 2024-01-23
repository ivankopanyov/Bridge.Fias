using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasMessageText"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasMessageTextOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasMessageText"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasMessageTextOptions"/>.
    /// </summary>
    public partial class FiasMessageText : FiasMessageFromPms
    {
        public long ReservationNumber { get; set; }

        public int MessageId { get; set; }

        public string MessageText { get; set; }

        public string RoomNumber { get; set; }

        public DateTime? DateTime { get; set; }
    }
}

