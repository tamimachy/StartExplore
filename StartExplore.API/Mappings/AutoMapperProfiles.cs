using AutoMapper;
using StartExplore.API.Models.DTO;
using StartExploreAPI.Models.Domain;

namespace StartExplore.API.Mappings
{
    public class AutoMapperProfiles : Profile
    { 
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
        }
    }
}
