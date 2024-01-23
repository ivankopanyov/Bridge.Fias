using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasDatabaseResyncStart"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasDatabaseResyncStartOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasDatabaseResyncStart"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasDatabaseResyncStartOptions"/>.
    /// </summary>
    public partial class FiasDatabaseResyncStart : FiasMessageFromPms
    {
        public DateTime DateTime { get; set; }
    }
}

