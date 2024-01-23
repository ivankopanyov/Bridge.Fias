using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasLocatorOn"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasLocatorOnOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasLocatorOn"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasLocatorOnOptions"/>.
    /// </summary>
    public partial class FiasLocatorOn : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 80.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 80.
        /// </summary>
        [Required]
        [StringLength(80)]
        public string ClearText { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_10"/> to <see cref="FiasEnviroments.MAX_10"/>.<br/>
        /// <b>Обязательно.</b><br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_10"/> до <see cref="FiasEnviroments.MAX_10"/>.
        /// </summary>
        [Required]
        [Range(FiasEnviroments.MIN_10, FiasEnviroments.MAX_10)]
        public long ReservationNumber { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public TimeOnly LocatorExpiryTime { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Rounded to the nearest minute.<br/>
        /// <b>Обязательно.</b><br/>
        /// Округляется до минут.
        /// </summary>
        [Required]
        public TimeOnly Time { get; set; }

        public DateOnly? Date { get; set; }

        /// <summary>
        /// Max length is 8.<br/>
        /// Максимальная длина = 8.
        /// </summary>
        [StringLength(8)]
        public string RoomNumber { get; set; }
    }
}

