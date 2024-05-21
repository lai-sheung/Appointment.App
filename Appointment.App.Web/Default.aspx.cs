namespace Appointment.App.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        public IQueryable<AppointmentModel> appointmentsGrid_GetData()
        {
            var db = new AppointmentContext();
            var result = db.Appointments;
            return result;
        }
    }
}