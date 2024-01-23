using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasGuestChange"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasGuestChangeOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasGuestChange"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasGuestChangeOptions"/>.
    /// </summary>
    public partial class FiasGuestChange : FiasMessageFromPms
    {
        /// <summary>
        /// Mandatory for guest-oriented systems.<br/>
        /// Обязательно для гостевых систем.
        /// </summary>
        public long ReservationNumber { get; set; }

        public string RoomNumber { get; set; }

        /// <summary>
        /// Mandatory for guest-oriented systems.<br/>
        /// Обязательно для гостевых систем.
        /// </summary>
        public bool ShareFlag { get; set; }

        /// <summary>
        /// The data expected in these fields may not be available in every installation.
        /// ORACLE recommends not to base any business logic on these fields.<br/>
        /// Requires special configuration in PMS.<br/>
        /// Данные, ожидаемые в этих полях, могут быть доступны не при каждой установке.
        /// ORACLE рекомендует не основывать какую-либо бизнес-логику на этих полях.<br/>
        /// Требует специальной настройки в PMS.
        /// </summary>
        public string[] UserDefinableFields { get; set; }

        public FiasClassesOfService? ClassOfService { get; set; }

        public DateTime? DateTime { get; set; }

        public long? ProfileNumber { get; set; }

        public DateOnly? GuestArrivalDate { get; set; }

        public DateOnly? GuestDepartureDate { get; set; }

        public string GuestFirstName { get; set; }

        public string GuestGroupNumber { get; set; }

        public FiasGuestLanguages? GuestLanguage { get; set; }

        public string GuestName { get; set; }

        public string GuestTitle { get; set; }

        public string GuestVipStatus { get; set; }

        /// <summary>
        /// Not available with all PMS systems, requires IFC version 8.<br/>
        /// Requires special configuration in PMS.<br/>
        /// Доступно не во всех системах PMS, требуется IFC версии 8.<br/>
        /// Требует специальной настройки в PMS.
        /// </summary>
        public FiasMinibarRights? MinibarRights { get; set; }

        /// <summary>
        /// The PMS NoPost status is of pure informational status.
        /// It does NOT mean that an extension should be barred.
        /// Barring is handled through the respective right
        /// (e.g., <see cref="ClassOfService"/> or <see cref="TVRights"/>).<br/>
        /// Статус PMS NoPost носит чисто информационный характер.
        /// Это НЕ означает, что расширение должно быть запрещено.
        /// Запрет осуществляется посредством соответствующего права
        /// (например, <see cref="ClassOfService"/> или <see cref="TVRights"/>).
        /// </summary>
        public bool? NoPostStatus { get; set; }

        /// <summary>
        /// Mandatory for systems that support room moves opposed to C/O
        /// of the old room and C/I of the new room.<br/>
        /// Обязательно для систем, которые поддерживают перемещение помещений
        /// в отличие от C/O старого помещения и C/I новой комнаты.
        /// </summary>
        public string OldRoomNumber { get; set; }

        /// <summary>
        /// Not available with all PMS systems, requires IFC version 8.<br/>
        /// Requires special configuration in PMS.<br/>
        /// Доступно не во всех системах PMS, требуется IFC версии 8.<br/>
        /// Требует специальной настройки в PMS.
        /// </summary>
        public FiasTVRights? TVRights { get; set; }

        /// <summary>
        /// Not available with all PMS systems, requires IFC version 8.<br/>
        /// Requires special configuration in PMS.<br/>
        /// Доступно не во всех системах PMS, требуется IFC версии 8.<br/>
        /// Требует специальной настройки в PMS.
        /// </summary>
        public FiasVideoRights? VideoRights { get; set; }

        public string WorkStationId { get; set; }

        public string EquipmentNumber { get; set; }

        public FiasEquipmentStatus? EquipmentStatus { get; set; }

        public string PoolId { get; set; }
    }
}

