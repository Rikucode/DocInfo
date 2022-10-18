using DomainLogic.IRepositories;
using DomainLogic.Models;
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
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public Result<Doctor> AddDoctor(Doctor doctor)
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
        public Result DeleteDoctor(Doctor doctor)
        {
            try
            {
                var result = _doctorRepository.DeleteDoctor(doctor);
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
        public Result<IEnumerable<Doctor>> GetDoctorsBySpeciality(Speciality speciality)
        {
            try
            {
                var result = _doctorRepository.GetDoctorsBySpeciality(speciality);
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
