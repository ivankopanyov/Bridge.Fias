using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasDatabaseResyncEnd"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasDatabaseResyncEndOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasDatabaseResyncEnd"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasDatabaseResyncEndOptions"/>.
    /// </summary>
    public partial class FiasDatabaseResyncRequest : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required..</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }
    }
}

