using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasPostingSimple"/></summary>
    [FiasOptions(typeof(FiasPostingSimple))]
    public class FiasPostingSimpleOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasPostingSimple.DateTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Date))]
        [FiasFor(nameof(FiasCommonMessage.Time))]
        public bool DateTime => true;

        /// <summary>Use <see cref="FiasPostingSimple.DialedDigits"/></summary>
        [FiasFor(nameof(FiasCommonMessage.DialedDigits))]
        public bool DialedDigits { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.Duration"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Duration))]
        public bool Duration { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.MinibarArticle"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MinibarArticle))]
        public bool MinibarArticle { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.NumberOfArticles"/></summary>
        [FiasFor(nameof(FiasCommonMessage.NumberOfArticles))]
        public bool NumberOfArticles { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.MeterOrTaxPulse"/></summary>
        [FiasFor(nameof(FiasCommonMessage.MeterOrTaxPulse))]
        public bool MeterOrTaxPulse { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.PostingType"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingType))]
        public bool PostingType => true;

        /// <summary>Use <see cref="FiasPostingSimple.RoomNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.RoomNumber))]
        public bool RoomNumber => true;

        /// <summary>Use <see cref="FiasPostingSimple.SalesOutlet"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SalesOutlet))]
        public bool SalesOutlet { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.TotalPostingAmount"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TotalPostingAmount))]
        public bool TotalPostingAmount { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.SubtotalForCashPosRoundingDifferences"/></summary>
        [FiasFor(nameof(FiasCommonMessage.SubtotalForCashPosRoundingDifferences))]
        public bool SubtotalForCashPosRoundingDifferences { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.CreditLimitOverrideFlag"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CreditLimitOverrideFlag))]
        public bool CreditLimitOverrideFlag { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.ClearText"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ClearText))]
        public bool ClearText { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.Covers"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Covers))]
        public bool Covers { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.Discounts"/></summary>
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

        /// <summary>Use <see cref="FiasPostingSimple.UserId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.UserId))]
        public bool UserId { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.PostingSequenceNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingSequenceNumber))]
        public bool PostingSequenceNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.PostingCallType"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingCallType))]
        public bool PostingCallType { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.PmsPaymentMethod"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PmsPaymentMethod))]
        public bool PmsPaymentMethod { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.PostingRoute"/></summary>
        [FiasFor(nameof(FiasCommonMessage.PostingRoute))]
        public bool PostingRoute { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.Subtotals"/></summary>
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

        /// <summary>Use <see cref="FiasPostingSimple.ServiceCharge"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ServiceCharge))]
        public bool ServiceCharge { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.ServingTime"/></summary>
        [FiasFor(nameof(FiasCommonMessage.ServingTime))]
        public bool ServingTime { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.TableNumber"/></summary>
        [FiasFor(nameof(FiasCommonMessage.TableNumber))]
        public bool TableNumber { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.Taxes"/></summary>
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

        /// <summary>Use <see cref="FiasPostingSimple.Tip"/></summary>
        [FiasFor(nameof(FiasCommonMessage.Tip))]
        public bool Tip { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.WorkStationId"/></summary>
        [FiasFor(nameof(FiasCommonMessage.WorkStationId))]
        public bool WorkStationId { get; set; }

        /// <summary>Use <see cref="FiasPostingSimple.CrossReferenceData"/></summary>
        [FiasFor(nameof(FiasCommonMessage.CrossReferenceData))]
        public bool CrossReferenceData { get; set; }
    }
}

