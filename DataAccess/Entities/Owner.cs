using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
