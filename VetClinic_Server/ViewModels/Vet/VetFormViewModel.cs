using System.ComponentModel.DataAnnotations;
using VetClinic_Server.Data.Models;

namespace VetClinic_Server.ViewModels.Vet
{
    public class VetFormViewModel
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Education { get; set; }
        public bool Available { get; set; }
        public bool HasEmergencyCertification { get; set; }
        public string? ImageUrl { get; set; }

        [Required]
        public int? SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}