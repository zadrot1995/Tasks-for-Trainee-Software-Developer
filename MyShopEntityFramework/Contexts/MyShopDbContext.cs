using Microsoft.EntityFrameworkCore;
using MyShopEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopEntityFramework.Contexts
{
    public class MyShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MyShopDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}
