using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasGuestBillBalance"/></summary>
    [FiasOptions(typeof(FiasGuestBillBalance))]
    public class FiasGuestBillBalanceOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasGuestBillBalance.BalanceAmount"/></summary>
        [FiasFor(nameof(FiasCommonMessage.BalanceAmount))]
        public bool BalanceAmount => true;

        /// <summary>Use <see cref="FiasGuestBillBalance.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasGuestBillBalance.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasGuestBillBalance.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasGuestBillBalance.DateTimeOptional"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }
    }
}

