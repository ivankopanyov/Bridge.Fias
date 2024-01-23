using Bridge.Fias.Entities.Base;
using System;
using System.Collections.Generic;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasKeyRequest"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasKeyRequestOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasKeyRequest"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasKeyRequestOptions"/>.
    /// </summary>
    public partial class FiasKeyRequest : FiasMessageFromPms
    {
        public string KeyCoder { get; set; }

        public FiasKeyTypes KeyType { get; set; }

        public string RoomNumber { get; set; }

        public string WorkStationId { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Недоступно с ключами One Shot.
        /// </summary>
        public string Track1Data { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Недоступно с ключами One Shot.
        /// </summary>
        public string Track2Data { get; set; }

        /// <summary>
        /// ‘One Shot’ Key only supports item 0.<br/>
        /// Requires special configuration in PMS.<br/>
        /// Ключ «One Shot» поддерживает только элемент 0.<br/>
        /// Требует специальной настройки в PMS.
        /// </summary>
        public string[] UserDefinableFields { get; set; }

        public string ClearText { get; set; }

        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Недоступно с ключами One Shot.
        /// </summary>
        public TimeOnly? DepartureTime { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Mandatory for On-Line key systems.<br/>
        /// Недоступно с ключами One Shot.<br/>
        /// Обязательно для систем ключей On-Line.
        /// </summary>
        public long? ReservationNumber { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Недоступно с ключами One Shot.
        /// </summary>
        public DateOnly? GuestArrivalDate { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Недоступно с ключами One Shot.
        /// </summary>
        public DateOnly? GuestDepartureDate { get; set; }

        public string GuestGroupNumber { get; set; }

        /// <summary>
        /// Do NOT use when using <see cref="ClearText"/>
        /// (e.g., to receive data to print on Key card). OPERA only.<br/>
        /// НЕ используйте при использовании <see cref="ClearText"/>
        /// (например, для получения данных для печати на ключ-карте). Только OPERA.
        /// </summary>
        public string GuestName { get; set; }

        public string UserId { get; set; }

        /// <summary>
        /// Do NOT use for On-Line systems.<br/>
        /// НЕ используйте для онлайн-систем.
        /// </summary>
        public int? KeyCount { get; set; }

        /// <summary>
        /// Not available with ‘One Shot’ Keys.<br/>
        /// Requires special configuration in PMS.<br/>
        /// Недоступно с ключами One Shot.<br/>
        /// Требует специальной настройки в PMS.
        /// </summary>
        public string KeyOptions { get; set; }

        public bool? UseKeyAnswerTrack3Data { get; set; }

        public IEnumerable<string> SuiteInfoCollection { get; set; }
    }
}

