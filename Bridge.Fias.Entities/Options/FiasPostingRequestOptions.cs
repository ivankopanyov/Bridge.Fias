using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasPostingRequest"/></summary>
    [FiasOptions(typeof(FiasPostingRequest))]
    public class FiasPostingRequestOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasPostingRequest.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.ReservationNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ReservationNumber))]
        public bool ReservationNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.GuestName"/></summary>
        [FiasFor(nameof(FiasCommonMessage.GuestName))]
        public bool GuestName { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.PostingInquiry"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingInquiry))]
        public bool PostingInquiry { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.PmsPaymentMethod"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PmsPaymentMethod))]
        public bool PmsPaymentMethod => true;

        /// <summary>Use <see cref="FiasPostingRequest.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.PostingSequenceNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingSequenceNumber))]
        public bool PostingSequenceNumber => true;

        /// <summary>Use <see cref="FiasPostingRequest.TotalPostingAmount"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TotalPostingAmount))]
        public bool TotalPostingAmount { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId => true;

        /// <summary>Use <see cref="FiasPostingRequest.FidelioStandardTrack2Format"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Track2Data))]
        public bool FidelioStandardTrack2Format { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.SubtotalForCashPosRoundingDifferences"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SubtotalForCashPosRoundingDifferences))]
        public bool SubtotalForCashPosRoundingDifferences { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.CheckNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CheckNumber))]
        public bool CheckNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.CreditLimitOverrideFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CreditLimitOverrideFlag))]
        public bool CreditLimitOverrideFlag { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.Covers"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Covers))]
        public bool Covers { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.Discounts"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Discount1))]
        [FiasFor(nameof(FiasCommonMessage.Discount2))]
        [FiasFor(nameof(FiasCommonMessage.Discount3))]
        [FiasFor(nameof(FiasCommonMessage.Discount4))]
        [FiasFor(nameof(FiasCommonMessage.Discount5))]
        [FiasFor(nameof(FiasCommonMessage.Discount6))]
        [FiasFor(nameof(FiasCommonMessage.Discount7))]
        [FiasFor(nameof(FiasCommonMessage.Discount8))]
        [FiasFor(nameof(FiasCommonMessage.Discount9))]
        public bool Discounts { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.DialedDigits"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DialedDigits))]
        public bool DialedDigits { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.Duration"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Duration))]
        public bool Duration { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.ProfileNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ProfileNumber))]
        public bool ProfileNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.MinibarArticle"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MinibarArticle))]
        public bool MinibarArticle { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.MinibarArticle"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MinibarArticle))]
        public bool NumberOfArticles { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.MaximumGuests"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MaximumGuests))]
        public bool MaximumGuests { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.PostingCallType"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingCallType))]
        public bool PostingCallType { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.PostingType"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingType))]
        public bool PostingType { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.Subtotals"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Subtotal1))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal2))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal3))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal4))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal5))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal6))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal7))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal8))]
        [FiasFor(nameof(FiasCommonMessage.Subtotal9))]
        public bool Subtotals { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.ServiceCharge"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ServiceCharge))]
        public bool ServiceCharge { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.SalesOutlet"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SalesOutlet))]
        public bool SalesOutlet { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.ServingTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ServingTime))]
        public bool ServingTime { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.TableNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TableNumber))]
        public bool TableNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.Taxes"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Tax1))]
        [FiasFor(nameof(FiasCommonMessage.Tax2))]
        [FiasFor(nameof(FiasCommonMessage.Tax3))]
        [FiasFor(nameof(FiasCommonMessage.Tax4))]
        [FiasFor(nameof(FiasCommonMessage.Tax5))]
        [FiasFor(nameof(FiasCommonMessage.Tax6))]
        [FiasFor(nameof(FiasCommonMessage.Tax7))]
        [FiasFor(nameof(FiasCommonMessage.Tax8))]
        [FiasFor(nameof(FiasCommonMessage.Tax9))]
        public bool Taxes { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.Tip"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Tip))]
        public bool Tip { get; set; }

        /// <summary>Use <see cref="FiasPostingRequest.CrossReferenceData"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CrossReferenceData))]
        public bool CrossReferenceData { get; set; }
    }
}

