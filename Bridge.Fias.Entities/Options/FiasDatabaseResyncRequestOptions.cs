using Bridge.Fias.Entities.Attributes;

namespace Bridge.Fias.Entities
{
    /// <summary>Options for <see cref="FiasDatabaseResyncRequest"/></summary>
    [FiasOptions(typeof(FiasDatabaseResyncRequest))]
    public class FiasDatabaseResyncRequestOptions : FiasOptions
    {
        /// <summary>Use <see cref="FiasDatabaseResyncRequest.DateTime"/></summary>
        public bool Date => true;

        /// <summary>Use time in <see cref="FiasDatabaseResyncRequest.DateTime"/></summary>
        public bool Time => true;
    }
}

