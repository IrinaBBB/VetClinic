using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Repository.IRepository;
using Model;
using AutoMapper;
using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Business.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;
        private readonly ILogger _logger;

        public AnimalRepository(IMapper mapper, ApplicationDbContext db, ILogger logger)
        {
            _mapper = mapper;
            _db = db;
            _logger = logger;
        }

        public async Task<AnimalDto> CreateAnimalAsync(AnimalDto animalDto)
        {
            var animal = _mapper.Map<AnimalDto, Animal>(animalDto);
            animal.DateRegistered = DateTime.UtcNow;
            animal.CreatedBy = "";

            var createdAnimal = _db.Animals.Add(animal);
            await _db.SaveChangesAsync();
            return _mapper.Map<Animal, AnimalDto>(createdAnimal.Entity);
        }

        public async Task<AnimalDto> UpdateAnimalAsync(int animalId, AnimalDto animalDto)
        {
            try
            {
                if (animalId != animalDto.Id) return null;

                var animalDetails = await _db.Animals.FindAsync(animalId);
                var animal = _mapper.Map(animalDto, animalDetails);
                animal.UpdatedBy = "";
                animal.DateUpdated = DateTime.UtcNow;
                var updatedAnimal = _db.Animals.Update(animal);
                await _db.SaveChangesAsync();
                return _mapper.Map<Animal, AnimalDto>(updatedAnimal.Entity);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Error updating Animal with id - {id} : {message}",
                    animalId, ex.Message);
                return null;
            }
        }

        public async Task<AnimalDto> GetAnimalAsync(int animalId)
        {
            try
            {
                var animalDto = _mapper.Map<Animal, AnimalDto>(
                    await _db.Animals.Include(x => x.Species)
                        .FirstOrDefaultAsync(x => x.Id == animalId));
                return animalDto;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Error getting animal with id - {id} : {message}",
                    animalId, ex.Message);
                return null;
            }
        }

        public IEnumerable<AnimalDto> GetAllAnimals()
        {
            return _mapper.Map<IEnumerable<Animal>, IEnumerable<AnimalDto>>(
                _db.Animals.Include(x => x.Species));
        }
    }
}
