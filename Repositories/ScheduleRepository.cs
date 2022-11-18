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
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationContext _context;

        public ScheduleRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Schedule? AddSchedule(ScheduleModel schedule)
        {
            _context.Schedules.Add(schedule);
            return schedule?.ToDomain();
        }

        public Schedule? GetSchedule(int doctor_id, DateOnly date)
        {
            var schedule = _context.Schedules.FirstOrDefault(s => (s.doctor_id == doctor_id) && (s.date == date));
            return schedule?.ToDomain();
        }

        public Schedule? GetScheduleById(int id)
        {
            var schedule = _context.Schedules.FirstOrDefault(s => s.id == id);
            return schedule?.ToDomain();
        }

        public bool RemoveSchedule(int id)
        {
            if (GetScheduleById(id) != null)
            {
                _context.Remove(id);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Schedule? UpdateSchedule(ScheduleModel newSchedule)
        {
            _context.Update(newSchedule);
            return newSchedule?.ToDomain();
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
