using VetClinic_Server.Data.Models;

namespace VetClinic_Server.ViewModels.Appointments
{
    public class BookTimeSlotViewModel
    {
        public DateTime TimeSlot { get; set; }
        public string? VetName { get; set; }
        public int? SelectedPetId { get; set; } 
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
