using Newtonsoft.Json;
using System;
using System.Globalization;

namespace Bridge.Fias.Entities.Json.Converters
{
    internal class FiasTimeConverter : JsonConverter
    {
        private readonly string _format;

        public FiasTimeConverter(string format)
        {
            if (string.IsNullOrWhiteSpace(format))
                throw new ArgumentNullException(nameof(format));

            _format = format;
        }

        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                if (reader.Value?.ToString() is string value)
                    return TimeOnly.ParseExact(value, _format, CultureInfo.InvariantCulture);

                return null;
            }
            catch
            {
                return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
            writer.WriteValue(value is TimeOnly time ? time.ToString(_format) : null);
    }
}

