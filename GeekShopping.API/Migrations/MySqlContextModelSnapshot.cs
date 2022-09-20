﻿// <auto-generated />
using GeekShopping.API.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.API.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.API.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryName = "T-shirt",
                            Description = "oaisdaoisdjaiosjdasoid",
                            ImageUrl = "www.google.com.br",
                            Name = "Name",
                            Price = 56.5m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryName = "T-shirt",
                            Description = "oaisdaoisdjaiosjdasoid",
                            ImageUrl = "www.google.com.br",
                            Name = "Name",
                            Price = 56.5m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "T-shirt",
                            Description = "oaisdaoisdjaiosjdasoid",
                            ImageUrl = "www.google.com.br",
                            Name = "Name",
                            Price = 56.5m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-shirt",
                            Description = "oaisdaoisdjaiosjdasoid",
                            ImageUrl = "www.google.com.br",
                            Name = "Name",
                            Price = 56.5m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt",
                            Description = "oaisdaoisdjaiosjdasoid",
                            ImageUrl = "www.google.com.br",
                            Name = "Name",
                            Price = 56.5m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt",
                            Description = "oaisdaoisdjaiosjdasoid",
                            ImageUrl = "www.google.com.br",
                            Name = "Name",
                            Price = 56.5m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
