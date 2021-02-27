using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NorthWind.Models;

namespace Northwind.DAL
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("NorthWindContext")
        {
            Database.SetInitializer<NorthwindContext>(new CreateDatabaseIfNotExists<NorthwindContext>());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }


        // optional . But i prefer singular Table Names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}