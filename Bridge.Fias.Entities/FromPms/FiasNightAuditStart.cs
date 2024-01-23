using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasNightAuditStart"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasNightAuditStartOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasNightAuditStart"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasNightAuditStartOptions"/>.
    /// </summary>
    public partial class FiasNightAuditStart : FiasMessageFromPms
    {
        public DateTime DateTime { get; set; }
    }
}

