using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasKeyReadRequest"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasKeyReadOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasKeyReadRequest"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasKeyReadOptions"/>.
    /// </summary>
    public partial class FiasKeyReadRequest : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required..</b><br/>
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
        /// Can only contain characters from the ASCII table in the range 32 to 127, inclusive.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 8.<br/>
        /// Может содержать только символы из таблицы ASCII в диапазоне от 32 до 127 включительно.
        /// </summary>
        [Required]
        [StringLength(8)]
        [RegularExpression(FiasEnviroments.AN_PATTERN)]
        public string KeyCoder { get; set; }

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
        /// Max length is 16.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 16.
        /// </summary>
        [Required]
        [StringLength(16)]
        public string WorkStationId { get; set; }

        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Only hours and minutes are used.<br/>
        /// Используются только часы и минуты.
        /// </summary>
        public TimeOnly? DepartureTime { get; set; }

        /// <summary>
        /// Max length is 40.<br/>
        /// Максимальная длина = 40.
        /// </summary>
        [StringLength(40)]
        public string GuestName { get; set; }

        /// <summary>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_10"/> to <see cref="FiasEnviroments.MAX_10"/>.<br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_10"/> до <see cref="FiasEnviroments.MAX_10"/>.
        /// </summary>
        [Range(FiasEnviroments.MIN_10, FiasEnviroments.MAX_10)]
        public long? ReservationNumber { get; set; }

        public DateOnly? GuestDepartureDate { get; set; }

        /// <summary>
        /// Max length is 20.<br/>
        /// Максимальная длина = 20.
        /// </summary>
        [StringLength(20)]
        public string KeyOptions { get; set; }

        /// <summary>
        /// Max length is 30.<br/>
        /// Максимальная длина = 30.
        /// </summary>
        [StringLength(30)]
        public string SuiteInfo { get; set; }
    }
}

