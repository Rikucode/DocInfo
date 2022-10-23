using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.IRepositories
{
    public interface IAppointmentRepository : IDisposable
    {
        public Appointment? AddAppointment(Doctor doctor, DateTime date);
        public bool RemoveAppointment(Appointment appointment);
        public Appointment? GetAppointment(Doctor doctor, DateTime date);
        public IEnumerable<Appointment> GetAppointmentsByDoctorId(int id);
        public IEnumerable<DateTime>? GetFreeDates(Speciality speciality);
    }
}
