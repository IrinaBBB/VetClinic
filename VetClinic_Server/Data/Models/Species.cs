using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.Data.Models
{
    public class Species
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<Pet> Pets { get; set; } = new();

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}