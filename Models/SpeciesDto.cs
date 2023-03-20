using System.ComponentModel.DataAnnotations;


namespace Model
{
    public class SpeciesDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
