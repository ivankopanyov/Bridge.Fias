using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasWakeupClear"/> to FIAS and
    /// to receive <see cref="FiasWakeupClear"/> from FIAS,
    /// send an instance of <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasWakeupClearOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasWakeupClear"/> в FIAS и
    /// получать <see cref="FiasWakeupClear"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasWakeupClearOptions"/>.
    /// </summary>
    public partial class FiasWakeupClear : FiasMessageToPms
    {
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Max length is 8. Can be longer with Suite8 or OPERA PMS.<br/>
        /// Максимальная длина = 8. Может быть длиннее с Suite8 или OPERA PMS.
        /// </summary>
        [StringLength(8)]
        public string RoomNumber { get; set; }
    }
}

