using DomainLogic.IRepositories;
using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Services
{
    public class ScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public Result<Schedule> GetSchedule(Doctor doctor, DateOnly date)
        {
            try
            {
                var result = _scheduleRepository.GetSchedule(doctor, date);
                return result is null ? Result.Fail<Schedule>("Не удалось получить расписание для данного врача на выбранную дату") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Schedule>("Error:" + e);
            }
        }
        public Result<Schedule> AddSchedule(Schedule schedule)
        {
            try
            {
                var result = _scheduleRepository.AddSchedule(schedule);
                return result is null ? Result.Fail<Schedule>("Не удалось добавить расписание") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Schedule>("Error:" + e);
            }
        }
        public Result RemoveSchedule(Schedule schedule)
        {
            try
            {
                var result = _scheduleRepository.RemoveSchedule(schedule);
                return result is false ? Result.Fail("Не удалось удалить расписание") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail("Error:" + e);
            }
        }
        public Result<Schedule> UpdateSchedule(Schedule oldSchedule, Schedule newSchedule)
        {
            try
            {
                var result = _scheduleRepository.UpdateSchedule(oldSchedule, newSchedule);
                return result is null ? Result.Fail<Schedule>("Не удалось обновить расписание") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Schedule>("Error" + e);
            }
        }
    }
}
