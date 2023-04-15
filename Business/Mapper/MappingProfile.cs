using AutoMapper;
using DataAccess.Entities;
using Model;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AnimalDto, Animal>();
            CreateMap<Animal, AnimalDto>();

            CreateMap<SpeciesDto, Species>();
            CreateMap<Species, SpeciesDto>();
        }
    }
}
