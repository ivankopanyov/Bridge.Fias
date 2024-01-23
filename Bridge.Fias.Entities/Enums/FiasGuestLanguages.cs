using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasGuestLanguages
    {
        [EnumMember(Value = "EA")]
        English,

        [EnumMember(Value = "FR")]
        French,

        [EnumMember(Value = "GE")]
        German,

        [EnumMember(Value = "IT")]
        Italian,

        [EnumMember(Value = "JA")]
        Japanese,

        [EnumMember(Value = "SP")]
        Spanish,

        [EnumMember(Value = "RU")]
        Russian
    }
}

