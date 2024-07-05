using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.Data.Models
{
    public class Specialization
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<Vet>? Vets { get; set; } = new List<Vet>();

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}

