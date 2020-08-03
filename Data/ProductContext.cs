using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week4Capstone.Models;

namespace Week4Capstone.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
           
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products")
                .Property(x => x.Name)
                    .HasMaxLength(50)
                    .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(x => x.Price)
                    .IsRequired();

        }


    }
}
