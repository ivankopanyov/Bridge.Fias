using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasDatabaseResyncEnd"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasDatabaseResyncEndOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasDatabaseResyncEnd"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasDatabaseResyncEndOptions"/>.
    /// </summary>
    public partial class FiasDatabaseResyncEnd : FiasMessageFromPms
    {
        public DateTime DateTime { get; set; }
    }
}

