using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasPostingAnswer"/></summary>
    [FiasOptions(typeof(FiasPostingAnswer))]
    public class FiasPostingAnswerOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasPostingAnswer.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasPostingAnswer.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>Use <see cref="FiasPostingAnswer.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;

        /// <summary>Use <see cref="FiasPostingAnswer.PostingSequenceNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingSequenceNumber))]
        public bool PostingSequenceNumber => true;

        /// <summary>Use <see cref="FiasPostingAnswer.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasPostingAnswer.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasPostingAnswer.CheckNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CheckNumber))]
        public bool CheckNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingAnswer.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingAnswer.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasPostingAnswer.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasPostingAnswer.SalesOutlet"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SalesOutlet))]
        public bool SalesOutlet { get; set; }
    }
}
