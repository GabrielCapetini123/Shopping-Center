﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shopping.ProductAPI.Model.Context;

#nullable disable

namespace Shopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20230504141346_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Shopping.ProductAPI.Model.Product", b =>
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
                            Id = 3L,
                            CategoryName = "T-shirt",
                            Description = "Camiseta da Nike em 100% algodão",
                            ImageUrl = "https://imgnike-a.akamaihd.net/1920x1920/016388IE.jpg",
                            Name = "Camiseta Nike Preta",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "T-shirt",
                            Description = "Camiseta da Adidas em 100% algodão",
                            ImageUrl = "https://gaston.vteximg.com.br/arquivos/ids/337744-420-420/2001155676_Ampliada.jpg?v=638035987668800000",
                            Name = "Camiseta Adidas Preta",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "T-shirt",
                            Description = "Camiseta da Hering em 100% algodão",
                            ImageUrl = "https://imgnike-a.akamaihd.net/1920x1920/016388IE.jpg",
                            Name = "Camiseta Hering",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-shirt",
                            Description = "Camiseta da Nike em 100% algodão",
                            ImageUrl = "https://cdn.dooca.store/946/products/c4lgbuzwcmrcemhzmsfxymisccwvok0cwhod.jpg?v=1658773028&webp=0",
                            Name = "Camiseta Nike Branca",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-shirt",
                            Description = "Camiseta da Adidas em 100% algodão",
                            ImageUrl = "https://centralsurf.vteximg.com.br/arquivos/ids/313815-1000-1000/Camiseta-Adidas-Logo-0.jpg?v=637387355630500000",
                            Name = "Camiseta Adidas Branca",
                            Price = 69.9m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
