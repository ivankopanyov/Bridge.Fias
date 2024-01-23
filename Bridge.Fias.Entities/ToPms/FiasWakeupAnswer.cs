using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasWakeupAnswer"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasWakeupAnswerOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasWakeupAnswer"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasWakeupAnswerOptions"/>.
    /// </summary>
    public partial class FiasWakeupAnswer : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public FiasAnswerStatuses AnswerStatus { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 8. Может быть длиннее с Suite8 или OPERA PMS.
        /// </summary>
        [Required]
        public string RoomNumber { get; set; }
    }
}

