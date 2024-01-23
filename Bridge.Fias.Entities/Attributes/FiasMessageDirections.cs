using System;

namespace Bridge.Fias.Entities.Attributes
{
    [Flags]
    public enum FiasMessageDirections
    {
        FromPms = 1,
        ToPms = 2
    }
}

