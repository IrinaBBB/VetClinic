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
        [Range(0, 1000, ErrorMessage="Weight should be between 1 and 1000 kilos")]
        public decimal? WeightInKilos { get; set; }
        public bool? Neutered { get; set; }
        [Range(0, 1000, ErrorMessage = "Value shoulb be between 0 and 100")]
        public int EscapeAttempts { get; set; }
        public bool Chipped { get; set; }
    }
}
