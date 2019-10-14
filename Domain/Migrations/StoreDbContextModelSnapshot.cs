﻿// <auto-generated />
using System;
using Domain.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Carts.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<Guid?>("PurchaseId");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Domain.Models.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Models.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<Guid?>("CartId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Models.Purchases.Purchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid?>("CustomerId");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Domain.Models.Carts.Cart", b =>
                {
                    b.HasOne("Domain.Models.Purchases.Purchase", "Purchase")
                        .WithMany("Carts")
                        .HasForeignKey("PurchaseId");
                });

            modelBuilder.Entity("Domain.Models.Products.Product", b =>
                {
                    b.HasOne("Domain.Models.Carts.Cart")
                        .WithMany("Products")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("Domain.Models.Purchases.Purchase", b =>
                {
                    b.HasOne("Domain.Models.Customers.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
