using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasMessageRequest"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasMessageRequestOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasMessageRequest"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasMessageRequestOptions"/>.
    /// </summary>
    public partial class FiasMessageRequest : FiasMessageToPms
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

        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 8. Can be longer with Suite8 or OPERA PMS.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 8. Может быть длиннее с Suite8 или OPERA PMS.
        /// </summary>
        [Required]
        public string RoomNumber { get; set; }

        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_8"/> to <see cref="FiasEnviroments.MAX_8"/>.<br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_8"/> до <see cref="FiasEnviroments.MAX_8"/>.
        /// </summary>
        [Range(FiasEnviroments.MIN_8, FiasEnviroments.MAX_8)]
        public int? MessageId { get; set; }

        /// <summary>
        /// Change or do not change message status to "received" during request action.<br/>
        /// Менять или не менять статус сообщения на "получено" во время действия запроса.
        /// </summary>
        public bool? ChangeStatus { get; set; }
    }
}

