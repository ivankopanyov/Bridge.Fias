using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    public partial class FiasLinkConfiguration : FiasMessageFromPms
    {
        public TimeSpan? EFTTimeout { get; set; }

        public TimeSpan? DLSTimeout { get; set; }

        public string PMSVersion { get; set; }

        public string IFCVersion { get; set; }

        public string IFCDriverVersion { get; set; }

        public string HotelId { get; set; }

        /// <summary>
        /// Room Payment methods as defined in the PMS.<br/>
        /// Способы оплаты номера как определено в PMS.
        /// </summary>
        public string[] RoomPaymentMethodsArray { get; set; }

        /// <summary>
        /// Cryptogram (Only for EFT functionality).<br/>
        /// Криптограмма (только для функций EFT).
        /// </summary>
        public string Cryptogram { get; set; }
    }
}

