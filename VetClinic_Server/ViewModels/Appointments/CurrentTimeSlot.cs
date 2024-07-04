namespace VetClinic_Server.ViewModels.Appointments
{
    public class CurrentTimeSlot
    {
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public string? Label { get; set; }
        public bool Available { get; set; } = false;
        public bool Booked { get; set; } = false;
    }
}
