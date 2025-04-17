using Microsoft.EntityFrameworkCore;
using NSU_PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS
{
    public class WinformDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }


        public WinformDbContext(DbContextOptions<WinformDbContext> options)
       : base(options)
        {
        }

        public WinformDbContext() // For production usage (e.g., `new WinformDbContext()`)
        {
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Use your actual SQL Server or SQLite DB here for production
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=NSU_PMS;User Id=ggwp;password=123;TrustServerCertificate=True;MultipleActiveResultSets=True;");
            }
            
        }
    }
}
