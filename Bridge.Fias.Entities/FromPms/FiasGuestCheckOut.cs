using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasGuestCheckOut"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasGuestCheckOutOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasGuestCheckOut"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasGuestCheckOutOptions"/>.
    /// </summary>
    public partial class FiasGuestCheckOut : FiasMessageFromPms
    {
        /// <summary>
        /// Mandatory for guest-oriented systems.<br/>
        /// May not be available during database swap.<br/>
        /// Обязательно для гостевых систем.<br/>
        /// Может быть недоступен во время замены базы данных.
        /// </summary>
        public long ReservationNumber { get; set; }

        public string RoomNumber { get; set; }

        /// <summary>
        /// Mandatory for guest-oriented systems.<br/>
        /// Обязательно для гостевых систем.
        /// </summary>
        public bool ShareFlag { get; set; }

        public DateTime? DateTime { get; set; }

        public bool SwapFlag { get; set; }

        public string WorkStationId { get; set; }

        public string EquipmentNumber { get; set; }

        public FiasEquipmentStatus? EquipmentStatus { get; set; }

        public string PoolId { get; set; }

        public string EquipmentNumberOfSourceRoom { get; set; }

        public FiasEquipmentStatus? EquipmentStatusOfSourceRoom { get; set; }

        public string PoolIdOfSourceRoom { get; set; }
    }
}

