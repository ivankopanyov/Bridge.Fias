using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasRoomMaidStatuses
    {
        [EnumMember(Value = "1")]
        DirtyVacant,

        [EnumMember(Value = "2")]
        DirtyOccupied,

        [EnumMember(Value = "3")]
        CleanVacant,

        [EnumMember(Value = "4")]
        CleanOccupied,

        [EnumMember(Value = "5")]
        InspectedVacant,

        [EnumMember(Value = "6")]
        InspectedOccupied
    }
}

