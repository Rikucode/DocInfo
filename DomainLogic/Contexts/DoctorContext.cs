using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Contexts
{
    public class DoctorContext : DbContext
    {
        public DoctorContext() : base("DefaultConnection")
        { }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
