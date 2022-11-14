using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.IRepositories
{
    public interface IDoctorRepository : IDisposable
    {
        public Doctor? AddDoctor(DoctorModel doctor);
        public bool DeleteDoctor(int id);
        public IEnumerable<Doctor>? GetAllDoctors();
        public Doctor? GetById(int id);
        public IEnumerable<Doctor>? GetDoctorsBySpeciality(int speciality_id);
    }
}
