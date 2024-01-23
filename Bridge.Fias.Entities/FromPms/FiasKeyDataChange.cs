using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasKeyDataChange"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasKeyDataChangeOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasKeyDataChange"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasKeyDataChangeOptions"/>.
    /// </summary>
    public partial class FiasKeyDataChange : FiasMessageFromPms
    {
        public long ReservationNumber { get; set; }

        public string KeyCoder { get; set; }

        public string RoomNumber { get; set; }

        /// <summary>
        /// Mandatory for Room move, not send for updated like validity changes.<br/>
        /// Обязательно при переезде комнаты, не отправляйте на обновление, как и при изменении срока действия.
        /// </summary>
        public string OldRoomNumber { get; set; }

        public string WorkStationId { get; set; }

        /// <summary>
        /// Not normally used, as the track data cannot usually be changed after
        /// the card has been encoded. <br/>
        /// Обычно не используется, так как данные трека обычно не могут быть изменены
        /// после того, как карта была закодирована.
        /// </summary>
        public string Track1Data { get; set; }

        /// <summary>
        /// Not normally used, as the track data cannot usually be changed after
        /// the card has been encoded. <br/>
        /// Обычно не используется, так как данные трека обычно не могут быть изменены
        /// после того, как карта была закодирована.
        /// </summary>
        public string Track2Data { get; set; }

        public string ClearText { get; set; }

        public string[] UserDefinableFields { get; set; }

        public DateTime? DateTime { get; set; }

        public TimeOnly? DepartureTime { get; set; }

        public DateOnly? GuestArrivalDate { get; set; }

        public DateOnly? GuestDepartureDate { get; set; }

        public string GuestGroupNumber { get; set; }

        /// <summary>
        /// Do NOT use when using <see cref="ClearText"/>
        /// (e.g., to receive data to print on Key card). OPERA only.<br/>
        /// Updating the guest name in PMS will not trigger a <see cref="FiasKeyDataChange"/>!<br/>
        /// НЕ используйте при использовании поля <see cref="ClearText"/>
        /// (например, для получения данных для печати на ключ-карте). Только OPERA.<br/>
        /// Обновление имени гостя в PMS не вызовет <see cref="FiasKeyDataChange"/>!
        /// </summary>
        public string GuestName { get; set; }

        public string UserId { get; set; }

        public bool? UseKeyAnswerTrack3Data { get; set; }

        public string SuiteInfo { get; set; }

        public string SuiteInformationOfOldRoom { get; set; }
    }
}

