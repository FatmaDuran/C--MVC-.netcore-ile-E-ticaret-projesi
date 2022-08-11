using Eshop.WebUI.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.WebUI.Repository.Concrete.EntityFramework
{
    public class EshopContext:DbContext
    {
        public EshopContext(DbContextOptions<EshopContext> options)
            :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ProductAttribute> Attributes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                 .HasKey(pk => new { pk.ProductId, pk.CategoryId });
        }
    }
}
