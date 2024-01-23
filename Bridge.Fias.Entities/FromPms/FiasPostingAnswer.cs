using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasPostingAnswer"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasPostingAnswerOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasPostingAnswer"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasPostingAnswerOptions"/>.
    /// </summary>
    public partial class FiasPostingAnswer : FiasMessageFromPms
    {
        public FiasAnswerStatuses AnswerStatus { get; set; }

        /// <summary>
        /// Required only if the search fails (<see cref="FiasPostingRequest"/> only).<br/>
        /// On OPERA PMS, the length can be much longer than 50 characters, with no final limitation.<br/>
        /// Требуется только в случае неудачного поиска (только <see cref="FiasPostingRequest"/>).<br/>
        /// В OPERA PMS длина может превышать 50 символов, без финального символа ограничения.
        /// </summary>
        public string ClearText { get; set; }

        public DateTime DateTime { get; set; }

        /// <summary>
        /// Required if posting is done with <see cref="FiasPostingRequest"/> - will be value from
        /// corresponding <see cref="FiasPostingRequest"/> or <see cref="FiasPostingSimple"/>.<br/>
        /// Обязательно, если публикация выполняется с <see cref="FiasPostingRequest"/> — будет
        /// значением из соответствующего <see cref="FiasPostingRequest"/> или <see cref="FiasPostingSimple"/>.
        /// </summary>
        public int PostingSequenceNumber { get; set; }

        public string RoomNumber { get; set; }

        /// <summary>
        /// Required if posting is done with <see cref="FiasPostingRequest"/> - will be value from
        /// corresponding <see cref="FiasPostingRequest"/> or <see cref="FiasPostingSimple"/>.<br/>
        /// Обязательно, если публикация выполняется с <see cref="FiasPostingRequest"/> — будет
        /// значением из соответствующего <see cref="FiasPostingRequest"/> или <see cref="FiasPostingSimple"/>.
        /// </summary>
        public string WorkStationId { get; set; }

        public int? CheckNumber { get; set; }

        /// <summary>
        /// Not available when <see cref="FiasPostingSimple"/> is used.<br/>
        /// Недоступно при использовании <see cref="FiasPostingSimple"/>.
        /// </summary>
        public long? ReservationNumber { get; set; }

        /// <summary>
        /// Not available when <see cref="FiasPostingSimple"/> is used.<br/>
        /// Недоступно при использовании <see cref="FiasPostingSimple"/>.
        /// </summary>
        public string GuestName { get; set; }

        public string UserId { get; set; }

        public int? SalesOutlet { get; set; }
    }
}

