using Microsoft.EntityFrameworkCore;
using DomainLogic;
using Models;

namespace Contexts
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public UserContext(DbContextOptions options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().HasIndex(model => model.id);
        }
    }
}