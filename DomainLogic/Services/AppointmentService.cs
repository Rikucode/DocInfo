using DomainLogic.IRepositories;
using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Services
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public Result<Appointment> AddAppointment(Doctor doctor, DateOnly date)
        {
            try
            {
                var result = _appointmentRepository.AddAppointment(doctor, date);
                return result is null ? Result.Fail<Appointment>("Не удалось сохранить запись на приём") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Appointment>("Error" + e);
            }
        }
        public Result RemoveAppointment(Appointment appointment)
        {
            try
            {
                var result = _appointmentRepository.RemoveAppointment(appointment);
                return result is false ? Result.Fail("Не удалось удалить бронь") : 
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail("Error" + e);
            }
        }
        public Result<IEnumerable<DateOnly>> GetFreeDates(Speciality speciality)
        {
            try
            {
                var result = _appointmentRepository.GetFreeDates(speciality);
                return result is null ? Result.Fail<IEnumerable<DateOnly>>("Не удалось получить список свободных дат") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<IEnumerable<DateOnly>>("Error" + e);
            }
        }

    }
}
