using Appointment.App.Models;
using AutoMapper;
using AppointmentData = Appointment.App.Infrastructure.Models.Appointment;

namespace Appointment.App.Mapper
{
    public class AppointmentMapper : Profile
    {
        public AppointmentMapper() {
            CreateMap<AppointmentData, AppointmentModel>();
            CreateMap<AppointmentModel, AppointmentData>();
        }
    }
}
