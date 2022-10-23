using DomainLogic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogic.Contexts
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext() : base("DefaultConnection")
        { }
        public DbSet<Appointment> Appointment { get; set; }
    }
}
