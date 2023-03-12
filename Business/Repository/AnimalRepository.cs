using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public AnimalRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<AnimalDto> CreateAnimal(AnimalDto animalDto)
        {
            var animal = _mapper.Map<AnimalDto, Animal>(animalDto);
            animal.DateRegistered = DateTime.Now;
            animal.CreatedBy = "";
            
            var addedAnimal = await _db.Animals.AddAsync(animal);
            await _db.SaveChangesAsync();

            return _mapper.Map<Animal, AnimalDto>(addedAnimal.Entity);
        }

        public async Task<int> DeleteAnimal(int id)
        {
            var animalToDelete = await _db.Animals.FindAsync(id);
            if (animalToDelete == null) return 0;
            _db.Animals.Remove(animalToDelete);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<AnimalDto>> GetAllAnimals()
        {
            try
            {
                var animalDtos =
                    _mapper.Map<IEnumerable<Animal>, IEnumerable<AnimalDto>>(_db.Animals);
                return animalDtos; 
            }
            catch {return null;}
        }

        public async Task<AnimalDto> GetAnimal(int animalId)
        {
            try
            {
                var animal = await _db.Animals.FirstOrDefaultAsync(x => x.Id == animalId);
                return _mapper.Map<Animal, AnimalDto>(animal);
            } catch { return null; } 
        }

        public async Task<AnimalDto> UpdateAnimal(int animalId, AnimalDto animalDto)
        {
            try
            {
                if (animalId == animalDto.Id)
                {
                    var animalToUpdate = await _db.Animals.FindAsync(animalId);
                    var animal = _mapper.Map(animalDto, animalToUpdate);
                    animal.DateUpdated = DateTime.Now;
                    animal.UpdatedBy = "";
                    var updatedAnimal = _db.Animals.Update(animal);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Animal, AnimalDto>(updatedAnimal.Entity);
                }
                else return null;
            }
            catch { return null; }
        }
    }
}
