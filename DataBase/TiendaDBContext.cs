using Microsoft.EntityFrameworkCore;
using Tienda_DataBase;

namespace DataBase
{
    public class TiendaDBContext : DbContext
    {
        public TiendaDBContext(DbContextOptions<TiendaDBContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<CurrentAccount> CurrentAccounts { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SalesDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SaleDetail>()
                .HasKey(sd => new { sd.SaleId, sd.ProductId });

            modelBuilder.Entity<CustomerAddress>()
               .HasKey(ca => new { ca.CustomerId, ca.AddressId });

            modelBuilder.Entity<CurrentAccount>()
                .HasOne(ca => ca.Sale)
                .WithMany()
                .HasForeignKey(ca => ca.SaleId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }

}