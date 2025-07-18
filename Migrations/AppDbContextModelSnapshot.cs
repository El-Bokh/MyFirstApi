﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstApi.Data;

#nullable disable

namespace MyFirstApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MyFirstApi.Models.Account", b =>
                {
                    b.Property<int>("AccID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AccID"));

                    b.Property<string>("AccName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AccID");

                    b.ToTable("accounts", (string)null);
                });

            modelBuilder.Entity("MyFirstApi.Models.JournalEntry", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("CreditAccount")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DebitAccount")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QaidCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("JournalEntries", (string)null);
                });

            modelBuilder.Entity("MyFirstApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyFirstApi.Models.Qaid", b =>
                {
                    b.Property<long>("QaidID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("QaidID"));

                    b.Property<int>("BranchNo")
                        .HasColumnType("int");

                    b.Property<int>("DocNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderDetails")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int");

                    b.Property<int>("QaidAccID")
                        .HasColumnType("int");

                    b.Property<int>("QaidCode")
                        .HasColumnType("int");

                    b.Property<double>("QaidCurrPrice")
                        .HasColumnType("double");

                    b.Property<double>("QaidD1")
                        .HasColumnType("double");

                    b.Property<double>("QaidD2")
                        .HasColumnType("double");

                    b.Property<string>("QaidDetails")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("QaidM1")
                        .HasColumnType("double");

                    b.Property<double>("QaidM2")
                        .HasColumnType("double");

                    b.Property<long>("QaidRef")
                        .HasColumnType("bigint");

                    b.Property<string>("QaidType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Review")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Sign")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("QaidID");

                    b.ToTable("qaid", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
