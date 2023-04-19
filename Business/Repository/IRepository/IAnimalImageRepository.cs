using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Business.Repository.IRepository
{
    public interface IAnimalImageRepository
    {
        public Task<int> CreateAnimalImageAsync(AnimalImageDto imageDto);
        public Task<int> DeleteAnimalImageByImageIdAsync(int imageId);
        public Task<int> DeleteAnimalImageByAnimalIdAsync(int animalId);
        public Task<int> DeleteAnimalImageByImageUrlAsync(string imageUrl);
        public Task<IEnumerable<AnimalImageDto>> GetAnimalImagesAsync(int animalId);
    }
}
