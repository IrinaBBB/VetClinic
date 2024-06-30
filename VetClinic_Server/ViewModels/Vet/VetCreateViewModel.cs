using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.ViewModels.Vet
{
    public class VetCreateViewModel
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Specialization { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Education { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}