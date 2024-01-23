using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasNightAuditEnd"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasNightAuditEndOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasNightAuditEnd"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasNightAuditEndOptions"/>.
    /// </summary>
    public partial class FiasNightAuditEnd : FiasMessageFromPms
    {
        public DateTime DateTime { get; set; }
    }
}

