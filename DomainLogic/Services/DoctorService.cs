using DomainLogic.IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IAppointmentRepository _appointmentRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public Result<Doctor> AddDoctor(DoctorModel doctor)
        {
            try
            {
                var result = _doctorRepository.AddDoctor(doctor);
                return result is null ? Result.Fail<Doctor>("Не удалось добавить врача") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Doctor>("Error" + e);
            }
        }
        public Result DeleteDoctor(int id)
        {
            if (_appointmentRepository.GetAppointmentsByDoctorId(id) is not null){
                return Result.Fail("Нельзя удалить врача с активными приёмами");
            }
            try
            {
                var result = _doctorRepository.DeleteDoctor(id);
                return result is false ? Result.Fail("Не удалось удалить врача") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail("Error" + e);
            }
        }
        public Result<IEnumerable<Doctor>> GetAllDoctors()
        {
            try
            {
                var result = _doctorRepository.GetAllDoctors();
                return result is null ? Result.Fail<IEnumerable<Doctor>>("Не удалось получить список врачей") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<IEnumerable<Doctor>>("Error:" + e);
            }
        }
        public Result<Doctor> GetDoctorById(int id)
        {
            try
            {
                var result = _doctorRepository.GetById(id);
                return result is null ? Result.Fail<Doctor>("Не удалось найти врача с данным ID") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Doctor>("Error" + e);
            }
        }
        public Result<IEnumerable<Doctor>> GetDoctorsBySpeciality(int speciality_id)
        {
            try
            {
                var result = _doctorRepository.GetDoctorsBySpeciality(speciality_id);
                return result is null ? Result.Fail<IEnumerable<Doctor>>("Не удалочь найти список врачей с данной специализацией") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<IEnumerable<Doctor>>("Error" + e);
            }
        }
    }
}
