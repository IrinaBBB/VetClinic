using System.Collections.Generic;
using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using DataAccess.Entities;
using Microsoft.Extensions.Logging;
using Model;

namespace Business.Repository
{
    public class SpeciesRepository : ISpeciesRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _db;
        private readonly ILogger _logger;

        public SpeciesRepository(IMapper mapper, ApplicationDbContext db, ILogger logger)
        {
            _mapper = mapper;
            _db = db;
            _logger = logger;
        }

        public IEnumerable<SpeciesDto> GetAllSpecies()
        {
            return _mapper.Map<IEnumerable<Species>, IEnumerable<SpeciesDto>>(_db.Species);
        }
    }
}