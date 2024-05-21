namespace Appointment.App.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime Date { get; set; }
        public string AppointmentWith { get; set; } = default!;
        public string Location { get; set; } = default!;
    }
}
