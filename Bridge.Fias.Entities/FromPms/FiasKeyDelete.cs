using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasKeyDelete"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasKeyDeleteOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasKeyDelete"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasKeyDeleteOptions"/>.
    /// </summary>
    public partial class FiasKeyDelete : FiasMessageFromPms
    {
        public string KeyCoder { get; set; }

        public string RoomNumber { get; set; }

        public string WorkStationId { get; set; }

        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Mandatory for On-Line key systems.<br/>
        /// Обязательно для систем ключей On-Line.
        /// </summary>
        public long? ReservationNumber { get; set; }

        public string UserId { get; set; }

        public bool? UseKeyAnswerTrack3Data { get; set; }

        public string SuiteInfo { get; set; }
    }
}

