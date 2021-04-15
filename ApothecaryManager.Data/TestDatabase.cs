using ApothecaryManager.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data
{
    class TestDatabaseContext : DbContext
    {
        public TestDatabaseContext() : base()
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<RetailSale> RetailSales { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
