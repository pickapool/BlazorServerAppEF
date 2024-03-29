using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebReceipt.Models;

namespace WebReceipt.Server.AppDatabaseContext
{
    public class AppDBContext : DbContext
    {
        public DbSet<UserAccountModel> Accounts { get; set; }
        public DbSet<ReceiptModel> Receipts { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccountModel>().ToTable("Accounts");
            modelBuilder.Entity<ReceiptModel>().ToTable("Receipts");
        }
    }
}
