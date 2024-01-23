using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasMinibarRights
    {
        [EnumMember(Value = "MU")]
        Unlock,

        [EnumMember(Value = "MN")]
        NormalVending,

        [EnumMember(Value = "ML")]
        Lock
    }
}

