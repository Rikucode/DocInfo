using DomainLogic.Contexts;
using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.IRepositories
{
    public interface IDoctorRepository : IDisposable
    {
        public Doctor? AddDoctor(Doctor doctor);
        public bool DeleteDoctor(Doctor doctor);
        public IEnumerable<Doctor>? GetAllDoctors();
        public Doctor? GetById(int id);
        public IEnumerable<Doctor>? GetDoctorsBySpeciality(Speciality speciality);
    }
}
