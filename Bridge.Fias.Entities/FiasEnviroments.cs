using Bridge.Fias.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Bridge.Fias.Entities
{
    public static class FiasEnviroments
    {
        public const char SEPARATOR = '|';

        public const char HEAD = '\x02';

        public const char TAIL = '\x03';

        public const int MAX_1 = 9;

        public const int MIN_1 = 0;

        public const int MAX_2 = 99;

        public const int MIN_2 = -9;

        public const int MAX_4 = 9999;

        public const int MIN_4 = -999;

        public const int MAX_5 = 99999;

        public const int MIN_5 = -9999;

        public const int MAX_6 = 999999;

        public const int MIN_6 = -99999;

        public const int MAX_8 = 99999999;

        public const int MIN_8 = -9999999;

        public const long MAX_10 = 9999999999;

        public const long MIN_10 = -999999999;

        public const string MAX_15 = "999999999999999";

        public const string MIN_15 = "-99999999999999";

        public const string MAX_19 = "9999999999999999999";

        public const string MIN_19 = "-999999999999999999";

        public const string MAX_20 = "99999999999999999999";

        public const string MIN_20 = "-9999999999999999999";

        public const string AN_PATTERN = "^[\x20-\x7F]*$";

        public const string FIAS_DATE_FORMAT = "yyMMdd";

        public const string FIAS_TIME_FORMAT = "HHmmss";

        public const string FIAS_TIME_FORMAT_WITHOUT_SECONDS = "HHmm";

        public const string FIAS_TIME_FORMAT_DEPARTURE = "HH:mm";

        private static readonly HashSet<Type> _messageTypes;

        private static readonly Dictionary<string, Type> _fromPmsIndicatorType;

        private static readonly Dictionary<string, Type> _toPmsIndicatorType;

        internal static IReadOnlyCollection<Type> MessageTypes => _messageTypes;

        internal static IReadOnlyDictionary<string, Type> FromPmsIndicatorType => _fromPmsIndicatorType;

        internal static IReadOnlyDictionary<string, Type> ToPmsIndicatorType => _toPmsIndicatorType;

        static FiasEnviroments()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.GetCustomAttribute<FiasMessageAttribute>() != null);

            _messageTypes = new HashSet<Type>();
            _toPmsIndicatorType = new Dictionary<string, Type>();
            _fromPmsIndicatorType = new Dictionary<string, Type>();

            foreach (var type in types)
            {
                if (type.GetCustomAttribute<FiasMessageAttribute>() is FiasMessageAttribute attribute)
                {
                    _messageTypes.Add(type);

                    if (attribute.Direction.HasFlag(FiasMessageDirections.FromPms))
                        _fromPmsIndicatorType.Add(attribute.Indicator, type);

                    if (attribute.Direction.HasFlag(FiasMessageDirections.ToPms))
                        _toPmsIndicatorType.Add(attribute.Indicator, type);
                }
            }
        }
    }
}