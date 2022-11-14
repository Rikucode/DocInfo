using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class DoctorContextFactory : IDesignTimeDbContextFactory<DoctorContext>
    {
        public DoctorContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DoctorContext>();
            optionsBuilder.UseSqlite(
                "Data Source=Database.db");

            return new DoctorContext(optionsBuilder.Options);
        }
    }
}
