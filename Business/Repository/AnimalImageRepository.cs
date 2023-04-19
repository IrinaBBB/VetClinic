using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Business.Repository
{
    public class AnimalImageRepository : IAnimalImageRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public AnimalImageRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> CreateAnimalImageAsync(AnimalImageDto imageDto)
        {
            var image = _mapper.Map<AnimalImageDto, AnimalImage>(imageDto);
            await _db.AnimalImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteAnimalImageByImageIdAsync(int imageId)
        {
            var image = await _db.AnimalImages.FindAsync(imageId);
            _db.AnimalImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteAnimalImageByAnimalIdAsync(int animalId)
        {
            var imageList = await _db.AnimalImages.Where(x => x.AnimalId == animalId).ToListAsync();
            _db.AnimalImages.RemoveRange(imageList);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteAnimalImageByImageUrlAsync(string imageUrl)
        {
            var allImages = await _db.AnimalImages.FirstOrDefaultAsync
                (x => x.AnimalImageUrl.ToLower() == imageUrl.ToLower());
            if (allImages == null)
            {
                return 0;
            }

            _db.AnimalImages.Remove(allImages);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<AnimalImageDto>> GetAnimalImagesAsync(int animalId)
        {
            var imageList = await _db.AnimalImages.Where(i => i.AnimalId == animalId).ToListAsync();
            return _mapper.Map<IEnumerable<AnimalImage>, IEnumerable<AnimalImageDto>>(imageList);
        }
    }
}