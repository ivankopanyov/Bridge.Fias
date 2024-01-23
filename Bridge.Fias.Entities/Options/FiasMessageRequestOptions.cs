using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasMessageRequest"/></summary>
    [FiasOptions(typeof(FiasMessageRequest))]
    public class FiasMessageRequestOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasMessageRequest.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasMessageRequest.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasMessageRequest.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasMessageRequest.MessageId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MessageId))]
        public bool MessageId { get; set; }

        /// <summary>Use <see cref="FiasMessageRequest.ChangeStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RequestType))]
        public bool ChangeStatus { get; set; }
    }
}

