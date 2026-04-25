using Microsoft.EntityFrameworkCore;
using Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_Database.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Store> Stores { get; set; }
        public DbSet<Models.Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Models.Customer>()
                    .HasKey(c => c.CustomerId);
            modelBuilder.Entity<Models.Product>()
                .HasKey(p => p.ProductId);
            modelBuilder.Entity<Models.Store>()
                .HasKey(s => s.StoreId);
            modelBuilder.Entity<Models.Sale>()
                .HasKey(s => s.SaleId);
            modelBuilder.Entity<Sale>()
                .Property(s => s.Date)
                .HasDefaultValueSql("GETDATE()");

        }
    }
}
