using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasTVRights
    {
        [EnumMember(Value = "TU")]
        UnlimitedPayChannels,

        [EnumMember(Value = "TM")]
        NoPayMovies,

        [EnumMember(Value = "TX")]
        NoAdultMovies,

        [EnumMember(Value = "TN")]
        NoTVRights
    }
}
