using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Contexts
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext() : base("DefaultConnection")
        { }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
