using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasGuestBillRequest"/></summary>
    [FiasOptions(typeof(FiasGuestBillRequest))]
    public class FiasGuestBillRequestOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasGuestBillRequest.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasGuestBillRequest.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasGuestBillRequest.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

