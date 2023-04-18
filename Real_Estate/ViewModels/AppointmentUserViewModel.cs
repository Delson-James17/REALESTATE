using Real_Estate.Models;

namespace Real_Estate.ViewModels
{
    public class AppointmentUserViewModel
    {
        public List<Appointment>? Appointments { get; set; } 
        public ApplicationUser? User { get; set; }
    }
}
