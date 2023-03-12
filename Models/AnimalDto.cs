using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AnimalDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a pet name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter species")]
        public string Species { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal? WeightInKilos { get; set; }
        public bool? Neutered { get; set; }
        public int EscapeAttempts { get; set; }
    }
}
