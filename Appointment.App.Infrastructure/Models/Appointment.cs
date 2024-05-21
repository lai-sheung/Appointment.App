using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.App.Infrastructure.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime Date { get; set; }
        public string Location { get; set; } = default!;
        public string AppointmentWith { get; set; } = default!;
    }
}
