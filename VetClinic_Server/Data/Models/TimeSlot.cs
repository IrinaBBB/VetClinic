using System.ComponentModel.DataAnnotations;

namespace VetClinic_Server.Data.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime Finish { get; set; }
        [Required]
        public int VetId { get; set; }
        public Vet? Vet { get; set; }
        public int? PetId { get; set; }
        public Pet? Pet { get; set; }
        public string? Description { get; set; }
    }
}
