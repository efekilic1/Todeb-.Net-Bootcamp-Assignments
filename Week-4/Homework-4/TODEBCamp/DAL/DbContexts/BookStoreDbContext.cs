﻿using Microsoft.EntityFrameworkCore;
using Models.Entities;


namespace DAL.DbContexts
{

    public class BookStoreDbContext : DbContext
    {
        // Databasede oluşacak tablolar 
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // PostgreSQL kullandığımız için UseNpgsql kullanarak database bağlantısını kuruyoruz.
            // Npgsql.EntityFrameworkCore.PostgreSQL paketini eklememiz gerekiyor.

            base.OnConfiguring(optionsBuilder.UseNpgsql("Host=localhost;Database=muhammedkilic;Username=postgres;Password=postgres"));

            // Migration Dotnet CLI codes
            // dotnet ef migrations add testmigration
            // dotnet ef database update
            // dotnet ef migrations remove

        }


    }
}
