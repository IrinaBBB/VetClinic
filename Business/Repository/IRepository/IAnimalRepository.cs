using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Business.Repository.IRepository
{
    public interface IAnimalRepository
    {
        public Task<AnimalDto> CreateAnimalAsync(AnimalDto animalDto);
        public Task<AnimalDto> UpdateAnimalAsync(int animalId, AnimalDto animalDto);
        public Task<AnimalDto> GetAnimalAsync(int animalId);
        public IEnumerable<AnimalDto> GetAllAnimals();
    }
}
