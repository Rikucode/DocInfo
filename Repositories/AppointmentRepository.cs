using Contexts;
using DomainLogic;
using DomainLogic.IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentContext _context;

        public AppointmentRepository(AppointmentContext context)
        {
            _context = context;
        }
        public Appointment? AddAppointment(AppointmentModel appointment)
        {
            _context.Appointments.Add(appointment);
            return appointment?.ToDomain();
        }

        public Appointment? GetAppointment(AppointmentModel appointment)
        {
            var appointmentI = _context.Appointments.FirstOrDefault(appointment);
            return appointmentI?.ToDomain();
        }
        public Appointment? GetAppointmentById(int id)
        {
            var appointment = _context.Appointments.FirstOrDefault(a => a.id == id);
            return appointment?.ToDomain();
        }
        public IEnumerable<Appointment> GetAppointmentsByDoctorId(int doctor_id)
        {
            var appointments = _context.Appointments.Where(a => a.doctor_id == doctor_id).ToList<AppointmentModel>();
            return appointments?.ToDomain();
        }

        public IEnumerable<DateTime>? GetFreeDates(int speciality_id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAppointment(int appointment_id)
        {
            if (GetAppointmentById(appointment_id) != null)
            {
                _context.Remove(appointment_id);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this._context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
