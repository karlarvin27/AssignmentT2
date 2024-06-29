﻿// <auto-generated />
using AssignmentT2.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentT2.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240629014844_addProductsToDb")]
    partial class addProductsToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssignmentT2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Repair"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Maintenance"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Add Products"
                        });
                });

            modelBuilder.Entity("AssignmentT2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price3")
                        .HasColumnType("float");

                    b.Property<double>("Price5")
                        .HasColumnType("float");

                    b.Property<string>("Services")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Maintenance",
                            ListPrice = 50.0,
                            Price = 50.0,
                            Price3 = 45.0,
                            Price5 = 40.0,
                            Services = "PMS"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tire Services",
                            ListPrice = 100.0,
                            Price = 100.0,
                            Price3 = 90.0,
                            Price5 = 80.0,
                            Services = "Tire Services"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Repairs for cars",
                            ListPrice = 1000.0,
                            Price = 1000.0,
                            Price3 = 980.0,
                            Price5 = 940.0,
                            Services = "Auto Repair"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
