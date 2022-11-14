using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexts
{
    public class ScheduleContextFactory : IDesignTimeDbContextFactory<ScheduleContext>
    {
        public ScheduleContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ScheduleContext>();
            optionsBuilder.UseSqlite(
                "Data Source=Database.db");

            return new ScheduleContext(optionsBuilder.Options);
        }
    }
}
