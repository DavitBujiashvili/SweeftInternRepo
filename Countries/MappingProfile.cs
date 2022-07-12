using AutoMapper;
using Countries.Dtos;

namespace Countries
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryInfo>();
        }
    }

}
