using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasVideoRights
    {
        [EnumMember(Value = "VA")]
        ViewBillAndRemoteCheckOut,

        [EnumMember(Value = "VB")]
        OnlyViewBill,

        [EnumMember(Value = "VN")]
        NoVideoRights
    }
}

