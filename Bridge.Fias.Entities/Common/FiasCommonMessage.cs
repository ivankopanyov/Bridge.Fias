using Bridge.Fias.Entities.Json.Writers;
using Bridge.Fias.Entities.Services.Mapping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace Bridge.Fias.Entities
{
    public partial class FiasCommonMessage
    {
        [JsonIgnore]
        private static readonly JsonSerializerSettings _jsonSerializerSettings = new JsonSerializerSettings()
        {
            Error = (se, ev) =>
            {
                ev.ErrorContext.Handled = true;
            }
        };

        [JsonIgnore]
        public string Indicator { get; set; }


        [JsonIgnore]
        public string Source { get; internal set; }


        [JsonIgnore]
        public DateTime? DateTime
        {
            get
            {
                if (Date is DateOnly date)
                    return date.ToDateTime(Time ?? default);

                return null;
            }

            set
            {
                if (value is DateTime dateTime)
                {
                    Date = DateOnly.FromDateTime(dateTime);
                    Time = TimeOnly.FromDateTime(dateTime);
                }
                else
                {
                    Date = null;
                    Time = null;
                }

            }
        }

        [JsonIgnore]
        public bool? ChangeStatus
        {
            get
            {
                switch (RequestType)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        return null;
                }
            }

            set
            {
                switch (value)
                {
                    case true:
                        RequestType = 1;
                        break;
                    case false:
                        RequestType = 0;
                        break;
                    default:
                        RequestType = null;
                        break;
                }
            }
        }

        [JsonIgnore]
        public FiasLinkDescriptionRequestTypes RequestTypes
        {
            set => RequestType = value?.Sum();
        }

        [JsonIgnore]
        public bool? UseKeyAnswerTrack3Data
        {
            get
            {
                switch (RequestType)
                {
                    case 0:
                        return false;
                    case 4: 
                        return true;
                    default:
                        return null;
                }
            }

            set
            {
                switch (value)
                {
                    case true:
                        RequestType = 4;
                        break;
                    case false:
                        RequestType = 0;
                        break;
                    default:
                        RequestType = null;
                        break;
                }
            }
        }

        [JsonIgnore]
        public decimal?[] Discounts
        {
            get => new decimal?[]
            {
            Discount1,
            Discount2,
            Discount3,
            Discount4,
            Discount5,
            Discount6,
            Discount7,
            Discount8,
            Discount9
            };

            set
            {
                Discount1 = value != null && value.Length > 0 ? value[0] : null;
                Discount2 = value != null && value.Length > 1 ? value[1] : null;
                Discount3 = value != null && value.Length > 2 ? value[2] : null;
                Discount4 = value != null && value.Length > 3 ? value[3] : null;
                Discount5 = value != null && value.Length > 4 ? value[4] : null;
                Discount6 = value != null && value.Length > 5 ? value[5] : null;
                Discount7 = value != null && value.Length > 6 ? value[6] : null;
                Discount8 = value != null && value.Length > 7 ? value[7] : null;
                Discount9 = value != null && value.Length > 8 ? value[8] : null;
            }
        }

        [JsonIgnore]
        public decimal?[] Subtotals
        {
            get => new decimal?[]
            {
            Subtotal1,
            Subtotal2,
            Subtotal3,
            Subtotal4,
            Subtotal5,
            Subtotal6,
            Subtotal7,
            Subtotal8,
            Subtotal9
            };

            set
            {
                Subtotal1 = value != null && value.Length > 0 ? value[0] : null;
                Subtotal2 = value != null && value.Length > 1 ? value[1] : null;
                Subtotal3 = value != null && value.Length > 2 ? value[2] : null;
                Subtotal4 = value != null && value.Length > 3 ? value[3] : null;
                Subtotal5 = value != null && value.Length > 4 ? value[4] : null;
                Subtotal6 = value != null && value.Length > 5 ? value[5] : null;
                Subtotal7 = value != null && value.Length > 6 ? value[6] : null;
                Subtotal8 = value != null && value.Length > 7 ? value[7] : null;
                Subtotal9 = value != null && value.Length > 8 ? value[8] : null;
            }
        }

        [JsonIgnore]
        public decimal?[] Taxes
        {
            get => new decimal?[]
            {
            Tax1,
            Tax2,
            Tax3,
            Tax4,
            Tax5,
            Tax6,
            Tax7,
            Tax8,
            Tax9
            };

            set
            {
                Tax1 = value != null && value.Length > 0 ? value[0] : null;
                Tax2 = value != null && value.Length > 1 ? value[1] : null;
                Tax3 = value != null && value.Length > 2 ? value[2] : null;
                Tax4 = value != null && value.Length > 3 ? value[3] : null;
                Tax5 = value != null && value.Length > 4 ? value[4] : null;
                Tax6 = value != null && value.Length > 5 ? value[5] : null;
                Tax7 = value != null && value.Length > 6 ? value[6] : null;
                Tax8 = value != null && value.Length > 7 ? value[7] : null;
                Tax9 = value != null && value.Length > 8 ? value[8] : null;
            }
        }

        [JsonIgnore]
        public string[] UserDefinableFields
        {
            get => new string[]
            {
            UserDefinableField0,
            UserDefinableField1,
            UserDefinableField2,
            UserDefinableField3,
            UserDefinableField4,
            UserDefinableField5,
            UserDefinableField6,
            UserDefinableField7,
            UserDefinableField8,
            UserDefinableField9
            };
        }

        [JsonIgnore]
        public IList<string> SuiteInfoCollection => SuiteInfo?.Split(';');

        [JsonIgnore]
        public TimeSpan? EFTTimeout1
        {
            get
            {
                if (UserDefinableField0?.Split(';') is string[] timeouts && timeouts.Length > 0
                    && int.TryParse(timeouts[0], out int timeout) && timeout >= 0)
                    return TimeSpan.FromSeconds(timeout);

                return null;
            }
        }

        [JsonIgnore]
        public TimeSpan? DLSTimeout
        {
            get
            {
                if (UserDefinableField0?.Split(';') is string[] timeouts && timeouts.Length > 1
                    && int.TryParse(timeouts[1], out int timeout) && timeout >= 0)
                    return TimeSpan.FromSeconds(timeout);

                return null;
            }
        }

        [JsonIgnore]
        public string PMSVersion => UserDefinableField1;

        [JsonIgnore]
        public string IFCVersion => UserDefinableField2;

        [JsonIgnore]
        public string IFCDriverVersion => UserDefinableField3;

        [JsonIgnore]
        public string[] RoomPaymentMethodsArray => RoomPaymentMethods?.Split(',');

        [JsonIgnore]
        public decimal? FidelioStandardTrack2Format
        {
            get
            {
                if (Track2Data != null && decimal.TryParse(Track2Data, out decimal value))
                    return value;

                return null;
            }

            set => Track2Data = value?.ToString();
        }
        public FiasCommonMessage() { }

        public FiasCommonMessage(string source) => Source = source;

        public FiasCommonMessage(string source, string indicator) : this(source) => Indicator = indicator;

        public virtual object ToFiasMessageToPmsObject() => Indicator != null
            && FiasEnviroments.ToPmsIndicatorType.TryGetValue(Indicator, out Type type)
            ? FiasMapper.Mapper.Map(this, type) : null;

        public virtual object ToFiasMessageFromPmsObject() => Indicator != null
            && FiasEnviroments.FromPmsIndicatorType.TryGetValue(Indicator, out Type type)
            ? FiasMapper.Mapper.Map(this, type) : null;

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext) =>
            (ToFiasMessageToPmsObject() ?? ToFiasMessageFromPmsObject()) is IValidatableObject validatableObject
                ? validatableObject.Validate(validationContext)
                : Enumerable.Empty<ValidationResult>();

        public override string ToString()
        {
            StringWriter stringWriter = new StringWriter();
            JsonSerializer serializer = new JsonSerializer();

            try
            {
                FiasJsonWriter writer = new FiasJsonWriter(stringWriter, Indicator);
                serializer.Serialize(writer, this);

                return stringWriter.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public static FiasCommonMessage FromString(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return new FiasCommonMessage(source);

            var items = source
                .TrimStart(FiasEnviroments.HEAD)
                .TrimEnd(FiasEnviroments.TAIL)
                .Split(new char[] { FiasEnviroments.SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

            if (items.Length == 0)
                return new FiasCommonMessage(source);

            var json = items.Length > 1
                ? string.Join(",", items.Skip(1).Select(item => item.Length <= 2 ? $"\"{item}\":\"\"" : $"\"{item.Substring(0, 2)}\":\"{item.Substring(2, item.Length - 2)}\""))
                : string.Empty;

            try
            {
                var fiasCommonMessage = JsonConvert.DeserializeObject<FiasCommonMessage>('{' + json + '}', _jsonSerializerSettings)
                    ?? new FiasCommonMessage();

                fiasCommonMessage.Source = source;
                fiasCommonMessage.Indicator = items[0];
                return fiasCommonMessage;
            }
            catch
            {
                return new FiasCommonMessage(source, items[0]);
            }
        }
    }
}

