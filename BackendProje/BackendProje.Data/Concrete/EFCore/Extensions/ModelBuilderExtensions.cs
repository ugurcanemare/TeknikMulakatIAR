using BackendProje.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Data.Concrete.EFCore.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {

            List<Product> products = new List<Product>()
            {
                new Product{Id= 1,Name="Telefon", Status=true,Price=17000 },
                new Product{Id= 2,Name="Bilgisayar", Status=true,Price=17000},
                new Product {Id= 3,Name="Tablet", Status=false,Price=17000}
            };
            modelBuilder.Entity<Product>().HasData(products);

            List<Order> orders = new List<Order>()
            {
                new Order{Id= 1,Count=25, Status=true,Address="İstanbul" },
                new Order{Id= 2,Count=50, Status=true,Address="Ankara" },
                new Order {Id= 3,Count=0, Status=false,Address="İzmir" }
            };
            modelBuilder.Entity<Order>().HasData(orders);
        }
    }
}
