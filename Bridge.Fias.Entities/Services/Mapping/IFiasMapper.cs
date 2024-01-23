using System;

namespace Bridge.Fias.Entities.Services.Mapping
{
    internal interface IFiasMapper
    {
        FiasCommonMessage Map(object source, Type sourceType);

        object Map(FiasCommonMessage source, Type destType);
    }
}

