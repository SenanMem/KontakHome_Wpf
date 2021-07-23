using KontakHomeWpf.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KontakHomeWpf.Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Customers { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DictionaryProduct> DictionaryProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName).AddJsonFile("AppSetting.json");
            var config = configuration.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
