using Newtonsoft.Json;
using System;

namespace Bridge.Fias.Entities.Json.Converters
{
    internal class FiasBoolConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value?.ToString())
            {
                case "Y":
                    return true;
                case "N":
                    return false;
                case "":
                    return false;
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
            writer.WriteValue((value is bool condition) ? (condition ? "Y" : "N") : null);
    }
}

