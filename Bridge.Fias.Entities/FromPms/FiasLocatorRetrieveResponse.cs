using Bridge.Fias.Entities.Base;
using System;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// To receive <see cref="FiasLocatorRetrieveResponse"/> from FIAS, send an instance of
    /// <see cref="FiasLinkRecord"/> to FIAS with an instance of
    /// <see cref="FiasLocatorRetrieveOptions"/> passed to the constructor.<br/>
    /// Чтобы получать <see cref="FiasLocatorRetrieveResponse"/> из FIAS, отправьте экземпляр
    /// <see cref="FiasLinkRecord"/> в FIAS с переданным в конструктор экземпляром
    /// <see cref="FiasLocatorRetrieveOptions"/>.
    /// </summary>
    public partial class FiasLocatorRetrieveResponse : FiasMessageFromPms
    {
        public FiasAnswerStatuses AnswerStatus { get; set; }

        public string ClearText { get; set; }

        public long ReservationNumber { get; set; }

        public TimeOnly LocatorExpiryTime { get; set; }

        public DateTime? DateTime { get; set; }

        public string RoomNumber { get; set; }

        public void AfterMapFrom(FiasCommonMessage source)
        {   
            if (ClearText == null)
                ClearText = string.Empty;

            if (RoomNumber == null)
                RoomNumber = string.Empty;
        }
    }
}

