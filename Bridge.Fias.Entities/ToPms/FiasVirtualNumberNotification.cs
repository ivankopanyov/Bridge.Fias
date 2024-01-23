using Bridge.Fias.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasVirtualNumberNotification"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasVirtualNumberNotificationOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasVirtualNumberNotification"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasVirtualNumberNotificationOptions"/>.
    /// </summary>
    public partial class FiasVirtualNumberNotification : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required.</b><br/>
        /// Can only contain characters from the ASCII table in the range 32 to 127, inclusive.<br/>
        /// <b>Обязательно.</b><br/>
        /// Может содержать только символы из таблицы ASCII в диапазоне от 32 до 127 включительно.
        /// </summary>
        [Required]
        [RegularExpression(FiasEnviroments.AN_PATTERN)]
        public string EquipmentNumber { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public FiasAnswerStatuses AnswerStatus { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 40.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 40.
        /// </summary>
        [Required]
        [StringLength(40)]
        public string ClearText { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 8.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 8.
        /// </summary>
        [Required]
        [StringLength(8)]
        public string RoomNumber { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public FiasEquipmentStatus EquipmentStatus { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Can only contain characters from the ASCII table in the range 32 to 127, inclusive.<br/>
        /// <b>Обязательно.</b><br/>
        /// Может содержать только символы из таблицы ASCII в диапазоне от 32 до 127 включительно.
        /// </summary>
        [Required]
        [RegularExpression(FiasEnviroments.AN_PATTERN)]
        public string PoolId { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_8"/> to <see cref="FiasEnviroments.MAX_8"/>.<br/>
        /// <b>Обязательно.</b><br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_8"/> до <see cref="FiasEnviroments.MAX_8"/>.
        /// </summary>
        [Required]
        [Range(FiasEnviroments.MIN_8, FiasEnviroments.MAX_8)]
        public long ReservationNumber { get; set; }

        /// <summary>
        /// Max length is 6.<br/>
        /// Максимальная длина = 6.
        /// </summary>
        [StringLength(6)]
        public string GuestPin { get; set; }
    }
}

