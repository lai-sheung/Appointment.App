using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appointment.App.Web
{
    public partial class AddAppointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }
    }
}