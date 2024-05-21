using Appointment.App.Web.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using System.Web.UI;

namespace Appointment.App.Web
{
    public partial class _Default : Page
    {
        ICollection<AppointmentModel> List  = new List<AppointmentModel>

        {
            new AppointmentModel
            {
                Id = 1,
                UserName = "Kees",
                Description = "test",
                Date = DateTime.Now,
                AppointmentWith = "Jan",
                Location = "Hier"
            }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        public ICollection<AppointmentModel> appointmentsGrid_GetData()
        {
            return List;
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAppointment");
        }
    }
}