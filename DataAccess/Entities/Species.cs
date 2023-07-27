using System.Collections.Generic;


namespace DataAccess.Entities
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Animal> Animals { get; set; } = new();
        public ICollection<Vet> Vets{ get; set; }
    }
}
