using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week4Capstone.Models;

namespace Week4Capstone.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Products.Any())
            {
                context.Products.Add(new Product() { Name = "Rose", Price = 24.99 });
                context.Products.Add(new Product() { Name = "Coneflower", Price = 7.99 });
                context.Products.Add(new Product() { Name = "Black-Eyed Susan", Price = 4.99 });
                context.Products.Add(new Product() { Name = "Coreopsis", Price = 9.99 });
                context.Products.Add(new Product() { Name = "Aster", Price = 17.99 });
                context.Products.Add(new Product() { Name = "Bee Balm", Price = 8.99 });
                context.Products.Add(new Product() { Name = "Hosta", Price = 18.99 });
                context.Products.Add(new Product() { Name = "Day Lily", Price = 11.99 });
                context.Products.Add(new Product() { Name = "Hydrangea", Price = 34.99 });
                context.Products.Add(new Product() { Name = "Azalea", Price = 19.99 });
                context.SaveChanges();
            }
        }
    }
}
