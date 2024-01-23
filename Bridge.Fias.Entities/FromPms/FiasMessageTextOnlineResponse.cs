using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasMessageTextOnlineResponse"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasMessageTextOnlineOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasMessageTextOnlineResponse"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasMessageTextOnlineOptions"/>.
    /// </summary>
    public partial class FiasMessageTextOnlineResponse : FiasMessageFromPms
    {
        public long ReservationNumber { get; set; }

        public int MessageId { get; set; }

        public string MessageText { get; set; }

        public string RoomNumber { get; set; }

        public DateTime? DateTime { get; set; }
    }
}

