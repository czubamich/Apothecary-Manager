using ApothecaryManager.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApothecaryManager.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
