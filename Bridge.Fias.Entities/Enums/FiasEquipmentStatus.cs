using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasEquipmentStatus
    {
        [EnumMember(Value = "0")]
        UnassignDidNumber,

        [EnumMember(Value = "1")]
        AssignDidNumber,

        [EnumMember(Value = "2")]
        KeepAssignedNumber,

        /// <summary>Only possible during Room-Move.</summary>
        [EnumMember(Value = "3")]
        MoovAssignedNumber
    }
}
