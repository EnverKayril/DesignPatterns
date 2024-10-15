using DesignPattern.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
        public Context(DbContextOptions<Context> options) : base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerName = "Ali Çınar", CustomerBalance = 28000 },
                new Customer { CustomerId = 2, CustomerName = "Zeynep Pınar", CustomerBalance = 32000 },
                new Customer { CustomerId = 3, CustomerName = "Mete Öztürk", CustomerBalance = 38000 }
                );
            base.OnModelCreating(modelBuilder);
        }


    }
}
