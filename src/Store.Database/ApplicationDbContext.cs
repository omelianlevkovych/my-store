using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<StockEntity> Stocks { get; set; }

        public DbSet<OrderEntity> Order { get; set; }

        public DbSet<ProductOrderEntity> ProductOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductOrderEntity>()
                .HasKey(key => new { key.ProductId, key.OrderId });
        }
    }
}
