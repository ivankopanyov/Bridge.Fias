using Bridge.Fias.Entities.Base;
using System.ComponentModel.DataAnnotations;
using Bridge.Fias.Entities.Attributes;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bridge.Fias.Entities
{
    public partial class FiasLinkRecord : FiasMessageToPms
    {
        [Required]
        public string RecordIndicator { get; private set; }

        [Required]
        public string FieldList { get; private set; }

        public FiasLinkRecord(FiasOptions recordOptions)
        {
            if (recordOptions is null)
                return;

            var type = recordOptions.GetType();
            if (type.GetCustomAttribute<FiasOptionsAttribute>() is FiasOptionsAttribute recordAttribute &&
                recordAttribute.Type?.GetCustomAttribute<FiasMessageAttribute>() is FiasMessageAttribute messageAttribute &&
                !string.IsNullOrWhiteSpace(messageAttribute.Indicator))
            {
                RecordIndicator = messageAttribute.Indicator;
                var properties = type.GetProperties()
                    .Where(property => property.PropertyType == typeof(bool) && property.GetValue(recordOptions) is bool value && value)
                    .SelectMany(property => property.GetCustomAttributes<FiasForAttribute>())
                    .Select(attribute => attribute.Name);

                var baseProperties = typeof(FiasCommonMessage).GetProperties();
                var fields = new HashSet<string>();
                foreach (var property in baseProperties)
                    if (properties.Contains(property.Name) &&
                        property.GetCustomAttribute<JsonPropertyAttribute>() is JsonPropertyAttribute attribute &&
                        !string.IsNullOrWhiteSpace(attribute.PropertyName))
                        fields.Add(attribute.PropertyName);

                if (fields.Count > 0)
                    FieldList = string.Join(string.Empty, fields);
            }
        }
    }
}

