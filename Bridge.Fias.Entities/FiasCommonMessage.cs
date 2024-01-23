using Bridge.Fias.Entities.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Bridge.Fias.Entities
{

    public partial class FiasCommonMessage
    {
        [JsonProperty(PropertyName = "DA")]
        [JsonConverter(typeof(FiasDateConverter), FiasEnviroments.FIAS_DATE_FORMAT)]
        public DateOnly? Date { get; set; }

        [JsonProperty(PropertyName = "TI")]
        [JsonConverter(typeof(FiasTimeConverter), FiasEnviroments.FIAS_TIME_FORMAT)]
        public TimeOnly? Time { get; set; }

        [JsonProperty(PropertyName = "IF")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasInterfaceTypes? InterfaceFamily { get; set; }

        [JsonProperty(PropertyName = "V#")]
        public string VendorSystemsVersion { get; set; }

        [JsonProperty(PropertyName = "EN")]
        public string EquipmentNumber { get; set; }

        [JsonProperty(PropertyName = "ES")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasEquipmentStatus? EquipmentStatus { get; set; }

        [JsonProperty(PropertyName = "EP")]
        public string PoolId { get; set; }

        [JsonProperty(PropertyName = "G#")]
        public long? ReservationNumber { get; set; }

        [JsonProperty(PropertyName = "RN")]
        public string RoomNumber { get; set; }

        [JsonProperty(PropertyName = "MI")]
        public int? MessageId { get; set; }

        [JsonProperty(PropertyName = "MT")]
        public string MessageText { get; set; }

        [JsonProperty(PropertyName = "PH")]
        public string HotelId { get; set; }

        [JsonProperty(PropertyName = "RP")]
        public string RoomPaymentMethods { get; set; }

        [JsonProperty(PropertyName = "CG")]
        public string Cryptogram { get; set; }

        [JsonProperty(PropertyName = "RL")]
        public int? MaximumRecordLength { get; set; }

        [JsonProperty(PropertyName = "RI")]
        public string RecordIndicator { get; set; }

        [JsonProperty(PropertyName = "FL")]
        public string FieldList { get; set; }

        [JsonProperty(PropertyName = "GS")]
        [JsonConverter(typeof(FiasBoolConverter))]
        public bool? ShareFlag { get; set; }

        [JsonProperty(PropertyName = "A0")]
        public string UserDefinableField0 { get; set; }

        [JsonProperty(PropertyName = "A1")]
        public string UserDefinableField1 { get; set; }

        [JsonProperty(PropertyName = "A2")]
        public string UserDefinableField2 { get; set; }

        [JsonProperty(PropertyName = "A3")]
        public string UserDefinableField3 { get; set; }

        [JsonProperty(PropertyName = "A4")]
        public string UserDefinableField4 { get; set; }

        [JsonProperty(PropertyName = "A5")]
        public string UserDefinableField5 { get; set; }

        [JsonProperty(PropertyName = "A6")]
        public string UserDefinableField6 { get; set; }

        [JsonProperty(PropertyName = "A7")]
        public string UserDefinableField7 { get; set; }

        [JsonProperty(PropertyName = "A8")]
        public string UserDefinableField8 { get; set; }

        [JsonProperty(PropertyName = "A9")]
        public string UserDefinableField9 { get; set; }

        [JsonProperty(PropertyName = "CS")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasClassesOfService? ClassOfService { get; set; }

        [JsonProperty(PropertyName = "G+")]
        public long? ProfileNumber { get; set; }

        [JsonProperty(PropertyName = "GA")]
        [JsonConverter(typeof(FiasDateConverter), FiasEnviroments.FIAS_DATE_FORMAT)]
        public DateOnly? GuestArrivalDate { get; set; }

        [JsonProperty(PropertyName = "GD")]
        [JsonConverter(typeof(FiasDateConverter), FiasEnviroments.FIAS_DATE_FORMAT)]
        public DateOnly? GuestDepartureDate { get; set; }

        [JsonProperty(PropertyName = "GF")]
        public string GuestFirstName { get; set; }

        [JsonProperty(PropertyName = "GG")]
        public string GuestGroupNumber { get; set; }

        [JsonProperty(PropertyName = "GL")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasGuestLanguages? GuestLanguage { get; set; }

        [JsonProperty(PropertyName = "GN")]
        public string GuestName { get; set; }

        [JsonProperty(PropertyName = "GT")]
        public string GuestTitle { get; set; }

        [JsonProperty(PropertyName = "GV")]
        public string GuestVipStatus { get; set; }

        [JsonProperty(PropertyName = "MR")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasMinibarRights? MinibarRights { get; set; }

        [JsonProperty(PropertyName = "NP")]
        [JsonConverter(typeof(FiasBoolConverter))]
        public bool? NoPostStatus { get; set; }

        [JsonProperty(PropertyName = "SF")]
        [JsonConverter(typeof(FiasFlagConverter))]
        public bool? SwapFlag { get; set; }

        [JsonProperty(PropertyName = "TV")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasTVRights? TVRights { get; set; }

        [JsonProperty(PropertyName = "VR")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasVideoRights? VideoRights { get; set; }

        [JsonProperty(PropertyName = "WS")]
        public string WorkStationId { get; set; }

        [JsonProperty(PropertyName = "RO")]
        public string OldRoomNumber { get; set; }

        [JsonProperty(PropertyName = "EO")]
        public string EquipmentNumberOfSourceRoom { get; set; }

        [JsonProperty(PropertyName = "ET")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasEquipmentStatus? EquipmentStatusOfSourceRoom { get; set; }

        [JsonProperty(PropertyName = "EI")]
        public string PoolIdOfSourceRoom { get; set; }

        [JsonProperty(PropertyName = "BD")]
        public string ItemDescription { get; set; }

        [JsonProperty(PropertyName = "BI")]
        public decimal? ItemAmount { get; set; }

        [JsonProperty(PropertyName = "DC")]
        public decimal? DepartmentCode { get; set; }

        [JsonProperty(PropertyName = "F#")]
        public int? FolioNumber { get; set; }

        [JsonProperty(PropertyName = "FD")]
        [JsonConverter(typeof(FiasBoolConverter))]
        public bool? ItemDisplayFlag { get; set; }

        [JsonProperty(PropertyName = "BA")]
        public decimal? BalanceAmount { get; set; }

        [JsonProperty(PropertyName = "AS")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasAnswerStatuses? AnswerStatus { get; set; }

        [JsonProperty(PropertyName = "CT")]
        public string ClearText { get; set; }

        [JsonProperty(PropertyName = "LT")]
        [JsonConverter(typeof(FiasTimeConverter), FiasEnviroments.FIAS_TIME_FORMAT_WITHOUT_SECONDS)]
        public TimeOnly? LocatorExpiryTime { get; set; }

        [JsonProperty(PropertyName = "DN")]
        [JsonConverter(typeof(FiasBoolConverter))]
        public bool? DoNotDisturb { get; set; }

        [JsonProperty(PropertyName = "ML")]
        [JsonConverter(typeof(FiasBoolConverter))]
        public bool? MessageLightStatus { get; set; }

        [JsonProperty(PropertyName = "RS")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasRoomMaidStatuses? RoomStatus { get; set; }

        [JsonProperty(PropertyName = "KC")]
        public string KeyCoder { get; set; }

        [JsonProperty(PropertyName = "KT")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasKeyTypes? KeyType { get; set; }

        [JsonProperty(PropertyName = "$1")]
        public string Track1Data { get; set; }

        [JsonProperty(PropertyName = "$2")]
        public string Track2Data { get; set; }

        [JsonProperty(PropertyName = "$3")]
        public string Track3Data { get; set; }

        [JsonProperty(PropertyName = "DT")]
        [JsonConverter(typeof(FiasTimeConverter), FiasEnviroments.FIAS_TIME_FORMAT_DEPARTURE)]
        public TimeOnly? DepartureTime { get; set; }

        [JsonProperty(PropertyName = "ID")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "K#")]
        public int? KeyCount { get; set; }

        [JsonProperty(PropertyName = "KO")]
        public string KeyOptions { get; set; }

        [JsonProperty(PropertyName = "RT")]
        public int? RequestType { get; set; }

        [JsonProperty(PropertyName = "SI")]
        public string SuiteInfo { get; set; }

        [JsonProperty(PropertyName = "UO")]
        public string SuiteInformationOfOldRoom { get; set; }

        [JsonProperty(PropertyName = "P#")]
        public int? PostingSequenceNumber { get; set; }

        [JsonProperty(PropertyName = "C#")]
        public int? CheckNumber { get; set; }

        [JsonProperty(PropertyName = "CL")]
        public long? CreditLimit { get; set; }

        [JsonProperty(PropertyName = "PM")]
        public string PmsPaymentMethod { get; set; }

        [JsonProperty(PropertyName = "SO")]
        public int? SalesOutlet { get; set; }

        [JsonProperty(PropertyName = "GP")]
        public string GuestPin { get; set; }

        [JsonProperty(PropertyName = "$J")]
        public int? ExternalMessageId { get; set; }

        [JsonProperty(PropertyName = "PP")]
        public int? PrinterPort { get; set; }

        [JsonProperty(PropertyName = "PU")]
        public int? NumberOfPersons { get; set; }

        [JsonProperty(PropertyName = "VM")]
        public string VoiceMail { get; set; }

        [JsonProperty(PropertyName = "DD")]
        public string DialedDigits { get; set; }

        [JsonProperty(PropertyName = "DU")]
        [JsonConverter(typeof(FiasTimeConverter), FiasEnviroments.FIAS_TIME_FORMAT)]
        public TimeOnly? Duration { get; set; }

        [JsonProperty(PropertyName = "MA")]
        public int? MinibarArticle { get; set; }

        [JsonProperty(PropertyName = "M#")]
        public int? NumberOfArticles { get; set; }

        [JsonProperty(PropertyName = "MP")]
        public long? MeterOrTaxPulse { get; set; }

        [JsonProperty(PropertyName = "PT")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasPostingTypes? PostingType { get; set; }

        [JsonProperty(PropertyName = "TA")]
        public decimal? TotalPostingAmount { get; set; }

        [JsonProperty(PropertyName = "+0")]
        public decimal? SubtotalForCashPosRoundingDifferences { get; set; }

        [JsonProperty(PropertyName = "CO")]
        [JsonConverter(typeof(FiasBoolConverter))]
        public bool? CreditLimitOverrideFlag { get; set; }

        [JsonProperty(PropertyName = "CV")]
        public int? Covers { get; set; }

        [JsonProperty(PropertyName = "D1")]
        public decimal? Discount1 { get; set; }

        [JsonProperty(PropertyName = "D2")]
        public decimal? Discount2 { get; set; }

        [JsonProperty(PropertyName = "D3")]
        public decimal? Discount3 { get; set; }

        [JsonProperty(PropertyName = "D4")]
        public decimal? Discount4 { get; set; }

        [JsonProperty(PropertyName = "D5")]
        public decimal? Discount5 { get; set; }

        [JsonProperty(PropertyName = "D6")]
        public decimal? Discount6 { get; set; }

        [JsonProperty(PropertyName = "D7")]
        public decimal? Discount7 { get; set; }

        [JsonProperty(PropertyName = "D8")]
        public decimal? Discount8 { get; set; }

        [JsonProperty(PropertyName = "D9")]
        public decimal? Discount9 { get; set; }

        [JsonProperty(PropertyName = "PC")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FiasPostingTypes? PostingCallType { get; set; }

        [JsonProperty(PropertyName = "PX")]
        public int? PostingRoute { get; set; }

        [JsonProperty(PropertyName = "S1")]
        public decimal? Subtotal1 { get; set; }

        [JsonProperty(PropertyName = "S2")]
        public decimal? Subtotal2 { get; set; }

        [JsonProperty(PropertyName = "S3")]
        public decimal? Subtotal3 { get; set; }

        [JsonProperty(PropertyName = "S4")]
        public decimal? Subtotal4 { get; set; }

        [JsonProperty(PropertyName = "S5")]
        public decimal? Subtotal5 { get; set; }

        [JsonProperty(PropertyName = "S6")]
        public decimal? Subtotal6 { get; set; }

        [JsonProperty(PropertyName = "S7")]
        public decimal? Subtotal7 { get; set; }

        [JsonProperty(PropertyName = "S8")]
        public decimal? Subtotal8 { get; set; }

        [JsonProperty(PropertyName = "S9")]
        public decimal? Subtotal9 { get; set; }

        [JsonProperty(PropertyName = "SC")]
        public decimal? ServiceCharge { get; set; }

        [JsonProperty(PropertyName = "ST")]
        public int? ServingTime { get; set; }

        [JsonProperty(PropertyName = "T#")]
        public int? TableNumber { get; set; }

        [JsonProperty(PropertyName = "T1")]
        public decimal? Tax1 { get; set; }

        [JsonProperty(PropertyName = "T2")]
        public decimal? Tax2 { get; set; }

        [JsonProperty(PropertyName = "T3")]
        public decimal? Tax3 { get; set; }

        [JsonProperty(PropertyName = "T4")]
        public decimal? Tax4 { get; set; }

        [JsonProperty(PropertyName = "T5")]
        public decimal? Tax5 { get; set; }

        [JsonProperty(PropertyName = "T6")]
        public decimal? Tax6 { get; set; }

        [JsonProperty(PropertyName = "T7")]
        public decimal? Tax7 { get; set; }

        [JsonProperty(PropertyName = "T8")]
        public decimal? Tax8 { get; set; }

        [JsonProperty(PropertyName = "T9")]
        public decimal? Tax9 { get; set; }

        [JsonProperty(PropertyName = "TP")]
        public decimal? Tip { get; set; }

        [JsonProperty(PropertyName = "X1")]
        public string CrossReferenceData { get; set; }

        [JsonProperty(PropertyName = "MX")]
        public int? MaximumGuests { get; set; }

        [JsonProperty(PropertyName = "PI")]
        public string PostingInquiry { get; set; }
    }
}

