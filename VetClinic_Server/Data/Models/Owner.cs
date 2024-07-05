using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.Data.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Email { get; set; }
        public string? Address { get; set; }

        [Required]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        public List<Pet>? Pets { get; set; } = new List<Pet>();

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}

