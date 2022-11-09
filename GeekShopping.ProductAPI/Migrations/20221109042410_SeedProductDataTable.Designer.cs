﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(SqlServercontext))]
    [Migration("20221109042410_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CategoryName");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Price");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 4L,
                            CategoryName = "Teste",
                            Description = "Teste de descrição",
                            ImageUrl = "https://teste.png",
                            Name = "Nome do produto teste",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "Teste",
                            Description = "Teste de descrição 5",
                            ImageUrl = "https://teste5.png",
                            Name = "Nome do produto teste 5",
                            Price = 89.9m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "Teste",
                            Description = "Teste de descrição 6",
                            ImageUrl = "https://teste6.png",
                            Name = "Nome do produto teste 6",
                            Price = 43.4m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "Teste",
                            Description = "Teste de descrição 7",
                            ImageUrl = "https://teste7.png",
                            Name = "Nome do produto teste 7",
                            Price = 15.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
