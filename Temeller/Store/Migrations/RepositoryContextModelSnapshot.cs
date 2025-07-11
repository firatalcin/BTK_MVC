﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Models;

#nullable disable

namespace Store.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("Store.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer",
                            Price = 17000m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Keyboard",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mouse",
                            Price = 500m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Monitor",
                            Price = 7000m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Deck",
                            Price = 1500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
