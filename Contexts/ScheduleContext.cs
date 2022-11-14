using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class ScheduleContext : DbContext
    {
        public DbSet<ScheduleModel> Schedules { get; set; }
        public ScheduleContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ScheduleModel>().HasIndex(model => model.id);
        }
    }
}
