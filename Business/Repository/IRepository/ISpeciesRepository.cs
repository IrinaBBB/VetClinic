using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Business.Repository.IRepository
{
    public interface ISpeciesRepository
    {
        public IEnumerable<SpeciesDto> GetAllSpecies();
    }
}
