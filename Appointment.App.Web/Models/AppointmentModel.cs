using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointment.App.Web.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string AppointmentWith { get; set; }
    }
}