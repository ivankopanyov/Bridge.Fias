using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasKeyReadResponse"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasKeyReadOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasKeyReadResponse"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasKeyReadOptions"/>.
    /// </summary>
    public partial class FiasKeyReadResponse : FiasMessageFromPms
    {
        public string KeyCoder { get; set; }

        public string WorkStationId { get; set; }

        public DateTime? DateTime { get; set; }
    }
}