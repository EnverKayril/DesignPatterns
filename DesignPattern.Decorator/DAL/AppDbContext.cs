using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ENVER\\SQLEXPRESS01; Database=DesignPattern1Decorator; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier> Notifiers { get; set; }
    }
}
