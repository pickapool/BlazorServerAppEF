using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebReceipt.Models;

namespace WebReceipt.Server.AppDatabaseContext
{
    public class AppDBContext : DbContext
    {
        public DbSet<UserAccountModel> Accounts { get; set; }
        public DbSet<ReceiptModel> Receipts { get; set; }
        public DbSet<PaymentTypeModel> PaymentTypes { get; set; }
        public DbSet<CedulaModel> Cedulas { get; set; }
        public DbSet<Form56Model> Form56s { get; set; }
        public DbSet<Form56DetailModel> Form56Details { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccountModel>().ToTable("Accounts");
            modelBuilder.Entity<ReceiptModel>().ToTable("Receipts");
            modelBuilder.Entity<PaymentTypeModel>().ToTable("PaymentTypes");
            modelBuilder.Entity<CedulaModel>().ToTable("Cedulas");
            modelBuilder.Entity<Form56Model>().ToTable("Form56s");
            modelBuilder.Entity<Form56DetailModel>().ToTable("Form56Details");
        }
    }
}
