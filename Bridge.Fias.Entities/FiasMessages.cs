using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    #region Both

    [FiasMessage("LS", FiasMessageDirections.FromPms | FiasMessageDirections.ToPms)]
    public partial class FiasLinkStart { }

    [FiasMessage("LA", FiasMessageDirections.FromPms | FiasMessageDirections.ToPms)]
    public partial class FiasLinkAlive { }

    [FiasMessage("LE", FiasMessageDirections.FromPms | FiasMessageDirections.ToPms)]
    public partial class FiasLinkEnd { }

    [FiasMessage("XD", FiasMessageDirections.FromPms | FiasMessageDirections.ToPms)]
    public partial class FiasMessageDelete { }

    [FiasMessage("WR", FiasMessageDirections.FromPms | FiasMessageDirections.ToPms)]
    public partial class FiasWakeupRequest { }

    [FiasMessage("WC", FiasMessageDirections.FromPms | FiasMessageDirections.ToPms)]
    public partial class FiasWakeupClear { }

    #endregion

    #region FromPms

    [FiasMessage("LC", FiasMessageDirections.FromPms)]
    public partial class FiasLinkConfiguration { }

    [FiasMessage("DS", FiasMessageDirections.FromPms)]
    public partial class FiasDatabaseResyncStart { }

    [FiasMessage("DE", FiasMessageDirections.FromPms)]
    public partial class FiasDatabaseResyncEnd { }

    [FiasMessage("NS", FiasMessageDirections.FromPms)]
    public partial class FiasNightAuditStart { }

    [FiasMessage("NE", FiasMessageDirections.FromPms)]
    public partial class FiasNightAuditEnd { }

    [FiasMessage("GI", FiasMessageDirections.FromPms)]
    public partial class FiasGuestCheckIn { }

    [FiasMessage("GO", FiasMessageDirections.FromPms)]
    public partial class FiasGuestCheckOut { }

    [FiasMessage("GC", FiasMessageDirections.FromPms)]
    public partial class FiasGuestChange { }

    [FiasMessage("XL", FiasMessageDirections.FromPms)]
    public partial class FiasMessageTextOnlineResponse { }

    [FiasMessage("XT", FiasMessageDirections.FromPms)]
    public partial class FiasMessageText { }

    [FiasMessage("XI", FiasMessageDirections.FromPms)]
    public partial class FiasGuestBillItem { }

    [FiasMessage("XB", FiasMessageDirections.FromPms)]
    public partial class FiasGuestBillBalance { }

    [FiasMessage("XC", FiasMessageDirections.FromPms)]
    public partial class FiasRemoteCheckOutResponse { }

    [FiasMessage("LP", FiasMessageDirections.FromPms)]
    public partial class FiasLocatorRetrieveResponse { }

    [FiasMessage("RE", FiasMessageDirections.FromPms)]
    public partial class FiasRoomEquipmentStatusResponse { }

    [FiasMessage("KR", FiasMessageDirections.FromPms)]
    public partial class FiasKeyRequest { }

    [FiasMessage("KM", FiasMessageDirections.FromPms)]
    public partial class FiasKeyDataChange { }

    [FiasMessage("KD", FiasMessageDirections.FromPms)]
    public partial class FiasKeyDelete { }

    [FiasMessage("KZ", FiasMessageDirections.FromPms)]
    public partial class FiasKeyReadResponse { }

    [FiasMessage("PL", FiasMessageDirections.FromPms)]
    public partial class FiasPostingList { }

    [FiasMessage("PA", FiasMessageDirections.FromPms)]
    public partial class FiasPostingAnswer { }

    #endregion

    #region ToPms

    [FiasMessage("LD", FiasMessageDirections.ToPms)]
    public partial class FiasLinkDescription { }

    [FiasMessage("LR", FiasMessageDirections.ToPms)]
    public partial class FiasLinkRecord { }

    [FiasMessage("DR", FiasMessageDirections.ToPms)]
    public partial class FiasDatabaseResyncRequest { }

    [FiasMessage("VA", FiasMessageDirections.ToPms)]
    public partial class FiasVirtualNumberNotification { }

    [FiasMessage("XL", FiasMessageDirections.ToPms)]
    public partial class FiasMessageTextOnlineRequest { }

    [FiasMessage("XM", FiasMessageDirections.ToPms)]
    public partial class FiasMessageRequest { }

    [FiasMessage("XR", FiasMessageDirections.ToPms)]
    public partial class FiasGuestBillRequest { }

    [FiasMessage("XC", FiasMessageDirections.ToPms)]
    public partial class FiasRemoteCheckOutRequest { }

    [FiasMessage("LO", FiasMessageDirections.ToPms)]
    public partial class FiasLocatorOn { }

    [FiasMessage("LF", FiasMessageDirections.ToPms)]
    public partial class FiasLocatorOff { }

    [FiasMessage("LP", FiasMessageDirections.ToPms)]
    public partial class FiasLocatorRetrieveRequest { }

    [FiasMessage("RE", FiasMessageDirections.ToPms)]
    public partial class FiasRoomEquipmentStatusRequest { }

    [FiasMessage("WA", FiasMessageDirections.ToPms)]
    public partial class FiasWakeupAnswer { }

    [FiasMessage("KA", FiasMessageDirections.ToPms)]
    public partial class FiasKeyAnswer { }

    [FiasMessage("KZ", FiasMessageDirections.ToPms)]
    public partial class FiasKeyReadRequest { }

    [FiasMessage("PS", FiasMessageDirections.ToPms)]
    public partial class FiasPostingSimple { }

    [FiasMessage("PR", FiasMessageDirections.ToPms)]
    public partial class FiasPostingRequest { }

    #endregion
}