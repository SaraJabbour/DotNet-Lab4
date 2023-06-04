﻿// <auto-generated />
using System;
using DotNet_Lab4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotNet_Lab4.Migrations
{
    [DbContext(typeof(DotNet_Lab4Context))]
    partial class DotNet_Lab4ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotNet_Lab4.Models.Customer", b =>
                {
                    b.Property<int>("CUSTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CUSTID"), 1L, 1);

                    b.Property<string>("CUSTDESC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.HasKey("CUSTID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DotNet_Lab4.Models.Orders", b =>
                {
                    b.Property<int>("OrdersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdersID"), 1L, 1);

                    b.Property<int>("CUSTID")
                        .HasColumnType("int");

                    b.Property<int>("MixID")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrdersTIME")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrdersType")
                        .HasColumnType("datetime2");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<bool>("deleted")
                        .HasColumnType("bit");

                    b.HasKey("OrdersID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DotNet_Lab4.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"), 1L, 1);

                    b.Property<string>("AmountCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustID")
                        .HasColumnType("int");

                    b.Property<double>("PayAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PayType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentType")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentID");

                    b.ToTable("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
