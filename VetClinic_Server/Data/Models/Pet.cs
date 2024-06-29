using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.Data.Models
{
    public enum Sex
    {
        Male = 1,
        Female = 2,
        Unknown = 0
    }

    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(10)]
        public Sex Sex { get; set; }

        public bool IsNeutered { get; set; }

        [Required]
        public int? SpeciesId { get; set; }
        public Species? Species { get; set; }
    }
}