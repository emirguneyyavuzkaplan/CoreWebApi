﻿// <auto-generated />
using System;
using HttpStatusCode.Infrastructure.Contex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HttpStatusCode.Migrations
{
    [DbContext(typeof(SqlDbcontext))]
    partial class SqlDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HttpStatusCode.Models.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2022, 6, 30, 12, 2, 39, 138, DateTimeKind.Local).AddTicks(3740),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Elektronik",
                            Name = "Elektronik",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2022, 6, 30, 12, 2, 39, 138, DateTimeKind.Local).AddTicks(3753),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tekstil",
                            Name = "Tekstil",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2022, 6, 30, 12, 2, 39, 138, DateTimeKind.Local).AddTicks(3753),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Yiycek",
                            Name = "Yiycek",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2022, 6, 30, 12, 2, 39, 138, DateTimeKind.Local).AddTicks(3757),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "İçecek",
                            Name = "İçecek",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2022, 6, 30, 12, 2, 39, 138, DateTimeKind.Local).AddTicks(3757),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nalburiye",
                            Name = "Nalburiye",
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
