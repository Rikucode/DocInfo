using Contexts;
using DomainLogic;
using DomainLogic.IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ApplicationContext _context;
        public DoctorRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Doctor? AddDoctor(DoctorModel doctor)
        {
            _context.Doctors.Add(doctor);
            return doctor?.ToDomain();
        }

        public bool DeleteDoctor(int id)
        {
            if (GetById(id) != null)
            {
                _context.Remove(id);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Doctor>? GetAllDoctors()
        {
            var doctor = _context.Doctors.ToList<DoctorModel>();
            return doctor?.ToDomain();
        }

        public Doctor? GetById(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.id == id);
            return doctor?.ToDomain();
        }

        public IEnumerable<Doctor>? GetDoctorsBySpeciality(int speciality_id)
        {
            var doctor = _context.Doctors.Where(d => d.speciality_id == speciality_id).ToList<DoctorModel>();
            return doctor?.ToDomain();
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
