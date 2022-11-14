using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.IRepositories
{
    public interface IScheduleRepository : IDisposable
    {
        public Schedule? GetSchedule(int doctor_id, DateOnly date);
        public Schedule? AddSchedule(ScheduleModel schedule);
        public Schedule? GetScheduleById(int id);
        public bool RemoveSchedule(int id);
        public Schedule? UpdateSchedule(ScheduleModel newSchedule);
    }
}
