using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENVER\\SQLEXPRESS01; Database=ChainOfResponsibility; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
