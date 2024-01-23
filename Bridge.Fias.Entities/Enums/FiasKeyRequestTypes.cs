using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasKeyRequestTypes
    {
        [EnumMember(Value = "0")]
        NotUsed1,

        [EnumMember(Value = "1")]
        NotUsed2,

        /// <summary>Request key data in the <see cref="KeyAnswer.Track3Data"/>.</summary>
        [EnumMember(Value = "2")]
        KeyAnswer
    }
}

