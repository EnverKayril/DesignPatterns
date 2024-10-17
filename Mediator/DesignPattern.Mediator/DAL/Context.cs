using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENVER\\SQLEXPRESS01; Database=DesignPattern8Mediator; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
