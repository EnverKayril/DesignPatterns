using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENVER\\SQLEXPRESS01; Database=DesignPattern2CQRS; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }

    }
}
