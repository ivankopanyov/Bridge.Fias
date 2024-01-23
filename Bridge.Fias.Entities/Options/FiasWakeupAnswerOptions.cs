using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasWakeupAnswer"/></summary>
    [FiasOptions(typeof(FiasWakeupAnswer))]
    public class FiasWakeupAnswerOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasWakeupAnswer.AnswerStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.AnswerStatus))]
        public bool AnswerStatus => true;

        /// <summary>Use <see cref="FiasWakeupAnswer.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;

        /// <summary>Use <see cref="FiasWakeupAnswer.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;
    }
}

