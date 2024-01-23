using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasInterfaceTypes
    {

        [EnumMember(Value = "CA")]
        CallAccounting,

        /// <summary>Key Services System</summary>
        [EnumMember(Value = "DL")]
        DoorLocking,

        [EnumMember(Value = "EM")]
        EnergyManagement,

        [EnumMember(Value = "MB")]
        Minibar,

        [EnumMember(Value = "PB")]
        TmsPbxGateway,

        [EnumMember(Value = "PO")]
        Pos,

        /// <summary>Extended Video Services</summary>
        [EnumMember(Value = "VI")]
        PayTV,

        [EnumMember(Value = "VM")]
        VoiceMail,

        /// <summary>Data Retrieval System</summary>
        [EnumMember(Value = "MS")]
        Miscellaneous,

        [EnumMember(Value = "WW")]
        InRoomInternetSystems
    }
}

