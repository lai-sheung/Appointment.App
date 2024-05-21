using Appointment.App.Infrastructure.Db;
using Appointment.App.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AppointmentData = Appointment.App.Infrastructure.Models.Appointment;


namespace Appointment.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentContext _context;
        private readonly IMapper _mapper;

        public AppointmentsController(AppointmentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<AppointmentData> GetAll()
        {
            return _context.Appointments;
        }

        // GET api/<AppointmentsController>/5
        [HttpGet("{id}")]
        public AppointmentData Get(int id)
        {
            return GetAppointment(id);
        }

        private AppointmentData GetAppointment(int id)
        {
            var appointment = _context.Appointments.Find(id);

            if (appointment == null)
            {
                throw new KeyNotFoundException("Appointment not found");
            }

            return appointment;
        }

        // POST api/<AppointmentsController>
        [HttpPost]
        public void Create([FromBody] AppointmentModel appointmentModel)
        {
            var appointment = _mapper.Map<AppointmentData>(appointmentModel);
            _context.Appointments.Add(appointment);
            _context.SaveChangesAsync();
        }

        // PUT api/<AppointmentsController>/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] AppointmentModel updatedAppointment)
        {
            var appointment = GetAppointment(id);

            _mapper.Map(updatedAppointment, appointment);
            _context.Appointments.Update(appointment);
            _context.SaveChanges();

        }

        // DELETE api/<AppointmentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var appointment = GetAppointment(id);
            _context.Appointments.Remove(appointment);
            _context.SaveChanges();
        }
    }
}
