using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace DomainLogic
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        {   }
        public DbSet<User> Users { get; set; }
    }
}
