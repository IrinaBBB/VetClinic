using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.Data.Models
{
    public class Vet
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        public string? Education { get; set; }

        public string? ImageUrl { get; set; }

        public bool Available { get; set; }

        public bool HasEmergencyCertification { get; set; }

        [Required]
        public int SpecializationId { get; set; }

        public Specialization? Specialization { get; set; }

        [Required]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}

