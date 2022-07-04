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
                            CreateDate = new DateTime(2022, 7, 4, 10, 58, 31, 409, DateTimeKind.Local).AddTicks(6240),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Elektronik",
                            Name = "Elektronik",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2022, 7, 4, 10, 58, 31, 409, DateTimeKind.Local).AddTicks(6253),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tekstil",
                            Name = "Tekstil",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2022, 7, 4, 10, 58, 31, 409, DateTimeKind.Local).AddTicks(6253),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Yiycek",
                            Name = "Yiycek",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2022, 7, 4, 10, 58, 31, 409, DateTimeKind.Local).AddTicks(6256),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "İçecek",
                            Name = "İçecek",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2022, 7, 4, 10, 58, 31, 409, DateTimeKind.Local).AddTicks(6256),
                            DeleteDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nalburiye",
                            Name = "Nalburiye",
                            Status = 0
                        });
                });

            modelBuilder.Entity("HttpStatusCode.Models.Entities.Concrete.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("HttpStatusCode.Models.Entities.Concrete.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("HttpStatusCode.Models.Entities.Concrete.Ilce", b =>
                {
                    b.HasOne("HttpStatusCode.Models.Entities.Concrete.Sehir", "Sehir")
                        .WithMany("Ilce")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("HttpStatusCode.Models.Entities.Concrete.Sehir", b =>
                {
                    b.Navigation("Ilce");
                });
#pragma warning restore 612, 618
        }
    }
}
