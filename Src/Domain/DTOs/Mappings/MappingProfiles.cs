using AutoMapper;

namespace Src.Domain.DTO.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PressaoArterial, PressaoArterialDTO>().ReverseMap();
        }
    }
}