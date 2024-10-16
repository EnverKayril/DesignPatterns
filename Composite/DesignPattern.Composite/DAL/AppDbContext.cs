using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENVER\\SQLEXPRESS01; Database=DesignPattern5Composite; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
