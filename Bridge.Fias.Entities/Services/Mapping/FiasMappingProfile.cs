using AutoMapper;

namespace Bridge.Fias.Entities.Services.Mapping
{
    internal class FiasMappingProfile : Profile
    {
        public FiasMappingProfile()
        {
            foreach (var type in FiasEnviroments.MessageTypes)
                CreateMap(typeof(FiasCommonMessage), type).ReverseMap();
        }
    }
}

