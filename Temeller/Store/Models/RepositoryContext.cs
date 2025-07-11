﻿using Microsoft.EntityFrameworkCore;

namespace Store.Models;

public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product(){ Id = 1, Name = "Computer", Price = 17000},
            new Product(){ Id = 2, Name = "Keyboard", Price = 1000},
            new Product(){ Id = 3, Name = "Mouse", Price = 500},
            new Product(){ Id = 4, Name = "Monitor", Price = 7000},
            new Product(){ Id = 5, Name = "Deck", Price = 1500}
            );
    }
}