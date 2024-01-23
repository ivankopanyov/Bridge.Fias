using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasKeyAnswer"/></summary>
    [FiasOptions(typeof(FiasKeyAnswer))]
    public class FiasKeyAnswerOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasKeyAnswer.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasKeyAnswer.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText => true;

        /// <summary>Use <see cref="FiasKeyAnswer.KeyCoder"/></summary>
        [FiasFor(nameof(FiasCommonMessage.KeyCoder))]
        public bool KeyCoder => true;

        /// <summary>Use <see cref="FiasKeyAnswer.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasKeyAnswer.Track2Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track2Data))]
        public bool Track2Data { get; set; }

        /// <summary>Use <see cref="FiasKeyAnswer.Track3Data"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track3Data))]
        public bool Track3Data { get; set; }

        /// <summary>Use <see cref="FiasKeyAnswer.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasKeyAnswer.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }
    }
}
