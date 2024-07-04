using VetClinic_Server.Data.Models;

namespace VetClinic_Server.ViewModels.Appointments
{
    public class AppointmentsAddViewModel
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public List<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    }
}
