using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class AppointmentContext : DbContext
    {
        public DbSet<AppointmentModel> Appointments { get; set; }
        public AppointmentContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppointmentModel>().HasIndex(model => model.id);
        }
    }
}
