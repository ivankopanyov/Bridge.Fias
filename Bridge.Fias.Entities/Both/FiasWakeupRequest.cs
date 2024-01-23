using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasWakeupRequest"/> to FIAS and
    /// to receive <see cref="FiasWakeupRequest"/> from FIAS,
    /// send an instance of <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasWakeupRequestOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasWakeupRequest"/> в FIAS и
    /// получать <see cref="FiasWakeupRequest"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasWakeupRequestOptions"/>.
    /// </summary>
    public partial class FiasWakeupRequest : FiasMessageToPms
    {
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 8. Can be longer with Suite8 or OPERA PMS.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 8. Может быть длиннее с Suite8 или OPERA PMS.
        /// </summary>
        [Required]
        public string RoomNumber { get; set; }
    }
}

