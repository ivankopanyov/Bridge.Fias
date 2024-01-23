using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasLocatorOn"/></summary>
    [FiasOptions(typeof(FiasLocatorOn))]
    public class FiasLocatorOnOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasLocatorOn.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>Use <see cref="FiasLocatorOn.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasLocatorOn.LocatorExpiryTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.LocatorExpiryTime))]
        public bool LocatorExpiryTime => true;

        /// <summary>Use <see cref="FiasLocatorOn.Time"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool Time => true;

        /// <summary>Use <see cref="FiasLocatorOn.Date"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        public bool Date { get; set; }

        /// <summary>Use <see cref="FiasLocatorOn.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber { get; set; }
    }
}

