using DomainLogic.IRepositories;
using Models;
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

        public Result<Schedule> GetSchedule(int doctor_id, DateOnly date)
        {
            try
            {
                var result = _scheduleRepository.GetSchedule(doctor_id, date);
                return result is null ? Result.Fail<Schedule>("Не удалось получить расписание для данного врача на выбранную дату") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail<Schedule>("Error:" + e);
            }
        }
        public Result<Schedule> AddSchedule(ScheduleModel schedule)
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
        public Result RemoveSchedule(int id)
        {
            try
            {
                var result = _scheduleRepository.RemoveSchedule(id);
                return result is false ? Result.Fail("Не удалось удалить расписание") :
                    Result.Ok(result);
            }
            catch(Exception e)
            {
                return Result.Fail("Error:" + e);
            }
        }
        public Result<Schedule> UpdateSchedule(ScheduleModel newSchedule)
        {
            try
            {
                var result = _scheduleRepository.UpdateSchedule(newSchedule);
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
