using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.IRepositories
{
    public interface IAppointmentRepository : IDisposable
    {
        public Appointment? AddAppointment(AppointmentModel appointment);
        public bool RemoveAppointment(int appointment_id);
        public Appointment? GetAppointmentById(int appointment_id);
        public Appointment? GetAppointment(AppointmentModel appointment);
        public IEnumerable<Appointment> GetAppointmentsByDoctorId(int id);
        public IEnumerable<DateTime>? GetFreeDates(int speciality_id);
    }
}
