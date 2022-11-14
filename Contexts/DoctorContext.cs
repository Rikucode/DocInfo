using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class DoctorContext : DbContext
    {
        public DbSet<DoctorModel> Doctors { get; set; }
        public DoctorContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<DoctorModel>().HasIndex(model => model.id);
        }
    }
}
