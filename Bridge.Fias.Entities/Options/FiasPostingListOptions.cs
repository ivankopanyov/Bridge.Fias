using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasPostingList"/></summary>
    [FiasOptions(typeof(FiasPostingList))]
    public class FiasPostingListOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasPostingList.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber => true;

        /// <summary>Use <see cref="FiasPostingList.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName => true;

        /// <summary>Use <see cref="FiasPostingList.PostingSequenceNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingSequenceNumber))]
        public bool PostingSequenceNumber => true;

        /// <summary>Use <see cref="FiasPostingList.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasPostingList.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasPostingList.UserDefinableFields"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField0))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField1))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField2))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField3))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField4))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField5))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField6))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField7))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField8))]
        [FiasFor(nameof(FiasCommonMessage.UserDefinableField9))]
        public bool UserDefinableFields { get; set; }

        /// <summary>Use <see cref="FiasPostingList.BalanceAmount"/></summary>
        [FiasFor(nameof(FiasCommonMessage.BalanceAmount))]
        public bool BalanceAmount { get; set; }

        /// <summary>Use <see cref="FiasPostingList.CheckNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CheckNumber))]
        public bool CheckNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingList.CreditLimit"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CreditLimit))]
        public bool CreditLimit { get; set; }

        /// <summary>Use <see cref="FiasPostingList.DateTimeOptional"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasPostingList.ProfileNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ProfileNumber))]
        public bool ProfileNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestArrivalDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestArrivalDate))]
        public bool GuestArrivalDate { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestDepartureDate"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestDepartureDate))]
        public bool GuestDepartureDate { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestFirstName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestFirstName))]
        public bool GuestFirstName { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestGroupNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestGroupNumber))]
        public bool GuestGroupNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestLanguage"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestLanguage))]
        public bool GuestLanguage { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestTitle"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestTitle))]
        public bool GuestTitle { get; set; }

        /// <summary>Use <see cref="FiasPostingList.GuestVipStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestVipStatus))]
        public bool GuestVipStatus { get; set; }

        /// <summary>Use <see cref="FiasPostingList.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasPostingList.NoPostStatus"/></summary>
        [FiasFor(nameof(FiasCommonMessage.NoPostStatus))]
        public bool NoPostStatus { get; set; }

        /// <summary>Use <see cref="FiasPostingList.PmsPaymentMethod"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PmsPaymentMethod))]
        public bool PmsPaymentMethod { get; set; }

        /// <summary>Use <see cref="FiasPostingList.SalesOutlet"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SalesOutlet))]
        public bool SalesOutlet { get; set; }
    }
}

