using Bridge.Fias.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To send <see cref="FiasRoomEquipmentStatusRequest"/> to FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasRoomEquipmentStatusOptions"/> passed to the constructor.<br/>
    /// Чтобы отправить <see cref="FiasRoomEquipmentStatusRequest"/> в FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasRoomEquipmentStatusOptions"/>.
    /// </summary>
    public partial class FiasRoomEquipmentStatusRequest : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 8. Can be longer with Suite8 or OPERA PMS.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 8. Может быть длиннее с Suite8 или OPERA PMS.
        /// </summary>
        [Required]
        [StringLength(8)]
        public string RoomNumber { get; set; }

        /// <summary>
        /// Max length is 40. Can be longer with Suite8 or OPERA PMS.<br/>
        /// Can only be used together with <see cref="PrinterPort"/>.<br/>
        /// Максимальная длина = 40. Может быть длиннее с Suite8 или OPERA PMS.<br/>
        /// Можно использовать только вместе с <see cref="PrinterPort"/>.
        /// </summary>
        [StringLength(40)]
        public string ClearText { get; set; }

        /// <summary>
        /// Max length is 16. Can be longer with Suite8 or OPERA PMS.<br/>
        /// Максимальная длина = 16. Может быть длиннее с Suite8 или OPERA PMS.
        /// </summary>
        [StringLength(16)]
        public string UserId { get; set; }

        /// <summary>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_1"/> to <see cref="FiasEnviroments.MAX_1"/>.<br/>
        /// Can only be used together with <see cref="ClearText"/>.<br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_1"/> до <see cref="FiasEnviroments.MAX_1"/>.<br/>
        /// Можно использовать только вместе с <see cref="ClearText"/>.
        /// </summary>
        [Range(FiasEnviroments.MIN_1, FiasEnviroments.MAX_1)]
        public int? PrinterPort { get; set; }

        /// <summary>
        /// Valid values ​​range from <see cref="FiasEnviroments.MIN_2"/> to <see cref="FiasEnviroments.MAX_2"/>.<br/>
        /// Can only be used together with <see cref="RoomStatus"/>.<br/>
        /// Currently only processed by Fidelio Suite8 and not by OPERA PMS.<br/>
        /// Допустимое значение в диапазоне от <see cref="FiasEnviroments.MIN_2"/> до <see cref="FiasEnviroments.MAX_2"/>.<br/>
        /// Можно использовать только вместе с <see cref="RoomStatus"/>.<br/>
        /// В настоящее время обрабатывается только Fidelio Suite8, а не OPERA PMS.
        /// </summary>
        [Range(FiasEnviroments.MIN_2, FiasEnviroments.MAX_2)]
        public int? NumberOfPersons { get; set; }

        public FiasRoomMaidStatuses? RoomStatus { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 4.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 4.
        /// </summary>
        [StringLength(4)]
        public string VoiceMail { get; set; }
    }
}

