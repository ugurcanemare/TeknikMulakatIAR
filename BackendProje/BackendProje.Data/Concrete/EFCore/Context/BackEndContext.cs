using BackendProje.Data.Concrete.EFCore.Config;
using BackendProje.Data.Concrete.EFCore.Extensions;
using BackendProje.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProje.Data.Concrete.EFCore.Context
{
    public class BackEndContext : DbContext
    {
        public BackEndContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfig).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
