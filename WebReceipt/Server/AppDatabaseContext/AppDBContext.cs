using Microsoft.EntityFrameworkCore;
using WebReceipt.Models;

namespace WebReceipt.Server.AppDatabaseContext
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
        public DbSet<UserAccountModel> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccountModel>().ToTable("Accounts");
        }
    }
}
