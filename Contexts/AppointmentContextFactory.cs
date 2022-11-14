using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class AppointmentContextFactory : IDesignTimeDbContextFactory<AppointmentContext>
    {
        public AppointmentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppointmentContext>();
            optionsBuilder.UseSqlite(
                "Data Source=Database.db");

            return new AppointmentContext(optionsBuilder.Options);
        }
    }
}
