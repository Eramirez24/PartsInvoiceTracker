using Microsoft.EntityFrameworkCore;
using PartsInvoiceTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsInvoiceTracker.AppData
{
    public class InvoiceContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= (localdb)\\MSSQLLocalDB; Inital Catalog=PartsInvoiceTracker");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
