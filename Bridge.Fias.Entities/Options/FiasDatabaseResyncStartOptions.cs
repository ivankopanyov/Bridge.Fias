using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasDatabaseResyncStart"/></summary>
    [FiasOptions(typeof(FiasDatabaseResyncStart))]
    public class FiasDatabaseResyncStartOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasDatabaseResyncStart.DateTime"/></summary>
        public bool Date => true;

        /// <summary>Use time in <see cref="FiasDatabaseResyncStart.DateTime"/></summary>
        public bool Time => true;
    }
}

