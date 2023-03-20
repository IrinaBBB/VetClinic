using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DataAccess.Entities
{
    public class Species
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();
    }
}
