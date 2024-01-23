using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasKeyTypes
    {
        /// <summary>Cancels any existing keys.</summary>
        [EnumMember(Value = "N")]
        NewKeyRequest,

        /// <summary>Any existing keys remain valid/active.</summary>
        [EnumMember(Value = "D")]
        DuplicateKeyRequest,

        /// <summary>The Key is only valid for use once.</summary>
        [EnumMember(Value = "O")]
        OneShotKey
    }
}