using AutoMapper;
using System;

namespace Bridge.Fias.Entities.Services.Mapping
{
    internal class FiasMapper : IFiasMapper
    {
        private static FiasMapper _fiasMapper;

        public static IFiasMapper Mapper
        {
            get
            {
                if (_fiasMapper == null)
                    _fiasMapper = new FiasMapper();

                return _fiasMapper;
            }
        }

        private readonly IMapper _mapper;

        private FiasMapper()
        { 
            if (_mapper == null)
                _mapper = new MapperConfiguration(OnConfiguring).CreateMapper();
        }

        public FiasCommonMessage Map(object source, Type sourceType) =>
            (FiasCommonMessage)_mapper.Map(source, sourceType, typeof(FiasCommonMessage));

        public object Map(FiasCommonMessage source, Type destType) =>
            _mapper.Map(source, typeof(FiasCommonMessage), destType);

        protected virtual void OnConfiguring(IMapperConfigurationExpression configuration) =>
            configuration.AddProfile<FiasMappingProfile>();
    }
}

