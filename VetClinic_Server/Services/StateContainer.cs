namespace VetClinic_Server.Services
{
    public class StateContainer
    {
        public int VetListPage { get; set; }
        public DateTime VetAppointmentDate { get; set; } = DateTime.Now;
    }
}


