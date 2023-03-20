using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DataAccess.Data
{
    public class Species
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        //public ICollection<Animal> animals { get; set; }
    }
}
