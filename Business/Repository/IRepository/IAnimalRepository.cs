using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAnimalRepository
    {
        public Task<AnimalDto> CreateAnimal(AnimalDto animal);
        public Task<AnimalDto> UpdateAnimal(int animalId, AnimalDto animal);
        public Task<int> DeleteAnimal(int id);
        public Task<AnimalDto> GetAnimal(int animalId);
        public Task<IEnumerable<AnimalDto>> GetAllAnimals();
    }
}
