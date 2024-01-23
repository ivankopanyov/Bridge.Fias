using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasPostingList"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasPostingListOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasPostingList"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasPostingListOptions"/>.
    /// </summary>
    public partial class FiasPostingList : FiasMessageFromPms
    {
        /// <summary>
        /// Required if the account(s) matching search information in <see cref="FiasPostingRequest"/> are found.<br/>
        /// Требуется, если найдены учетные записи, соответствующие поисковой информации в <see cref="FiasPostingRequest"/>.
        /// </summary>
        public long ReservationNumber { get; set; }

        /// <summary>
        /// Required if the account(s) matching search information in <see cref="FiasPostingRequest"/> are found.<br/>
        /// Требуется, если найдены учетные записи, соответствующие поисковой информации в <see cref="FiasPostingRequest"/>.
        /// </summary>
        public string GuestName { get; set; }

        /// <summary>
        /// Will be valued from the corresponding <see cref="FiasPostingRequest"/>.<br/>
        /// Будет оцениваться на основе соответствующего <see cref="FiasPostingRequest"/>.
        /// </summary>
        public int PostingSequenceNumber { get; set; }

        /// <summary>
        /// Required if the account(s) matching search information in <see cref="FiasPostingRequest"/> are found.<br/>
        /// Требуется, если найдены учетные записи, соответствующие поисковой информации в <see cref="FiasPostingRequest"/>.
        /// </summary>
        public string RoomNumber { get; set; }

        public string WorkStationId { get; set; }

        /// <summary>
        /// Requires configuration in PMS.<br/>
        /// Требует настройки в PMS.
        /// </summary>
        public string[] UserDefinableFields { get; set; }

        public decimal? BalanceAmount { get; set; }

        public int? CheckNumber { get; set; }

        /// <summary>
        /// Requires configuration in PMS.<br/>
        /// Требует настройки в PMS.
        /// </summary>
        public long? CreditLimit { get; set; }

        public DateTime? DateTime { get; set; }

        public long? ProfileNumber { get; set; }

        public DateOnly? GuestArrivalDate { get; set; }

        public DateOnly? GuestDepartureDate { get; set; }

        public string GuestFirstName { get; set; }

        public string GuestGroupNumber { get; set; }

        public FiasGuestLanguages? GuestLanguage { get; set; }

        public string GuestTitle { get; set; }

        public string GuestVipStatus { get; set; }

        public string UserId { get; set; }

        public bool? NoPostStatus { get; set; }

        public string PmsPaymentMethod { get; set; }

        public int? SalesOutlet { get; set; }
    }
}

