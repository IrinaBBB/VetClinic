using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Model;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class SpeciesRepository : ISpeciesRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public SpeciesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<SpeciesDto> CreateSpecies(SpeciesDto speciesDto)
        {
            var species = _mapper.Map<SpeciesDto, Species>(speciesDto);
            var addedSpecies = await _db.Species.AddAsync(species);
            await _db.SaveChangesAsync();

            return _mapper.Map<Species, SpeciesDto>(addedSpecies.Entity);
        }

        public async Task<int> DeleteSpecies(int id)
        {
            var speciesToDelete = await _db.Species.FindAsync(id);
            if (speciesToDelete == null) return 0;
            _db.Species.Remove(speciesToDelete);
            return await _db.SaveChangesAsync();
        }

  
        public async Task<IEnumerable<SpeciesDto>> GetAllSpecies()
        {
            try
            {
                var speciesDtos =
                    _mapper.Map<IEnumerable<Species>, IEnumerable<SpeciesDto>>(_db.Species);
                return speciesDtos;
            }
            catch { return null; }
        }

        public async Task<SpeciesDto> GetSpecies(int speciesId)
        {
            try
            {
                var species = await _db.Species.FirstOrDefaultAsync(x => x.Id == speciesId);
                return _mapper.Map<Species, SpeciesDto>(species);
            }
            catch { return null; }
        }

        public async Task<SpeciesDto> UpdateSpecies(int speciesId, SpeciesDto speciesDto)
        {
            try
            {
                if (speciesId == speciesDto.Id)
                {
                    var speciesToUpdate = await _db.Species.FindAsync(speciesId);
                    var species = _mapper.Map(speciesDto, speciesToUpdate);
                    var updatedSpecies = _db.Species.Update(species);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Species, SpeciesDto>(updatedSpecies.Entity);
                }
                else return null;
            }
            catch { return null; }
        }
    }
}
