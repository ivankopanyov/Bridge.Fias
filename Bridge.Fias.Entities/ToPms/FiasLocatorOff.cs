using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasLocatorOff"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasLocatorOffOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasLocatorOff"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasLocatorOffOptions"/>.
    /// </summary>
    public partial class FiasLocatorOff : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required.</b><br/>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_10"/> to <see cref="FiasEnviroments.MAX_10"/>.<br/>
        /// <b>Обязательно.</b><br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_10"/> до <see cref="FiasEnviroments.MAX_10"/>.
        /// </summary>
        [Required]
        [Range(FiasEnviroments.MIN_10, FiasEnviroments.MAX_10)]
        public long ReservationNumber { get; set; }

        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Max length is 8.<br/>
        /// Максимальная длина = 8.
        /// </summary>
        [StringLength(8)]
        public string RoomNumber { get; set; }
    }
}

