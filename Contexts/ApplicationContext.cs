using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<ScheduleModel> Schedules { get; set; }
        public DbSet<AppointmentModel> Appointments { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().HasIndex(model => model.id);
            modelBuilder.Entity<DoctorModel>().HasIndex(model => model.id);
            modelBuilder.Entity<ScheduleModel>().HasIndex(model => model.id);
            modelBuilder.Entity<AppointmentModel>().HasIndex(model => model.id);
        }
    }
}
