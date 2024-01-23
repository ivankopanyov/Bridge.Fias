using System;
using System.Linq;

namespace Bridge.Fias.Entities
{
    public abstract class FiasOptions
    {
        internal FiasOptions() { }

        public static T All<T>() where T : FiasOptions, new()
        {
            if (Activator.CreateInstance(typeof(T)) is T options)
            {

                var setters = typeof(T)
                    .GetProperties()
                    .Select(property => property.SetMethod)
                    .Where(method => method != null);

                try
                {
                    foreach (var setter in setters)
                        setter.Invoke(options, new object[] { true });

                    return options;
                }
                catch
                {
                    return null;
                }
            }

            return null;
        }
    }
}

