using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISpeciesRepository
    {
        public Task<SpeciesDto> CreateSpecies(SpeciesDto species);
        public Task<SpeciesDto> UpdateSpecies(int speciesId, SpeciesDto speciesDto);
        public Task<int> DeleteSpecies(int id);
        public Task<SpeciesDto> GetSpecies(int speciesId);
        public Task<IEnumerable<SpeciesDto>> GetAllSpecies();
    }
}
