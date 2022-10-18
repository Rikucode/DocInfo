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
        public Appointment? AddAppointment(Doctor doctor, DateOnly date);
        public bool RemoveAppointment(Appointment appointment);
        public IEnumerable<DateOnly>? GetFreeDates(Speciality speciality);
    }
}
