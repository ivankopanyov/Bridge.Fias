using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasRemoteCheckOutResponse"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasRemoteCheckOutOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasRemoteCheckOutResponse"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasRemoteCheckOutOptions"/>.
    /// </summary>
    public partial class FiasRemoteCheckOutResponse : FiasMessageFromPms
    {
        /// <summary>
        /// Sent from PMS to show the status of a request.<br/>
        /// Отправлено из PMS для отображения статуса запроса.
        /// </summary>
        public FiasAnswerStatuses AnswerStatus { get; set; }

        /// <summary>
        /// Sent as part of Remote Check-out request.<br/>
        /// Отправляется как часть запроса на удаленный выезд.
        /// </summary>
        public decimal BalanceAmount { get; set; }

        /// <summary>
        /// Sent from PMS to show the status of a request.<br/>
        /// Отправлено из PMS для отображения статуса запроса.
        /// </summary>
        public string ClearText { get; set; }

        public long ReservationNumber { get; set; }

        public string RoomNumber { get; set; }

        public DateTime? DateTime { get; set; }
    }
}

