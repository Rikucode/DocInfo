using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogic.Models;

namespace DomainLogic.IRepositories
{
    public interface IScheduleRepository : IDisposable
    {
        public Schedule? GetSchedule(Doctor doctor, DateOnly date);
        public Schedule? AddSchedule(Schedule schedule);
        public bool RemoveSchedule(Schedule schedule);
        public Schedule? UpdateSchedule(Schedule oldSchedule, Schedule newSchedule);
    }
}
