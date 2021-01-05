﻿// <auto-generated />
using System;
using Entities.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(ShortenLinkContext))]
    partial class ShortenLinkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Entities.Model.EmployeeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ffbed34c-4b39-11eb-ae93-0242ac130002"),
                            Email = "mail_1@mail.com",
                            FullName = "Nguyen Van A",
                            Password = "AQAAAAEAACcQAAAAEMgx+n/MIyy/JV2Zc0eKsPIUx6wp1K+DQOLPowCESO2RNpQ3AKdYoe1L7z478MMVvw==",
                            RoleId = new Guid("6f6c4608-4b39-11eb-ae93-0242ac130002"),
                            UserName = "user"
                        },
                        new
                        {
                            Id = new Guid("ad7e7c58-4b3a-11eb-ae93-0242ac130002"),
                            Email = "mail_2@mail.com",
                            FullName = "Nguyen Van N",
                            Password = "AQAAAAEAACcQAAAAEP7z3pyKo4Jczkv3Ki+QsDOk/etv81vjUOo4YPQC/7YdIwoNMatOfHl7YDc5aIlS3Q==",
                            RoleId = new Guid("aeeccc6d-e50f-43d9-92cf-e5b89acb8c83"),
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Entities.Model.LinkDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("LinkDatas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("867e6316-4b44-11eb-ae93-0242ac130002"),
                            Count = 0,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = new Guid("ffbed34c-4b39-11eb-ae93-0242ac130002"),
                            FullLink = "https://www.google.com",
                            ShortLink = "google"
                        },
                        new
                        {
                            Id = new Guid("a63771fc-4b44-11eb-ae93-0242ac130002"),
                            Count = 0,
                            CreatedAt = new DateTime(2021, 1, 5, 10, 44, 44, 4, DateTimeKind.Local).AddTicks(3435),
                            EmployeeId = new Guid("ffbed34c-4b39-11eb-ae93-0242ac130002"),
                            FullLink = "https://www.uuidgenerator.net/version1",
                            ShortLink = "uuidgen"
                        },
                        new
                        {
                            Id = new Guid("a4a31ddf-d56a-4209-8030-d3a696edf8eb"),
                            Count = 0,
                            CreatedAt = new DateTime(2021, 1, 5, 10, 44, 44, 5, DateTimeKind.Local).AddTicks(739),
                            EmployeeId = new Guid("ffbed34c-4b39-11eb-ae93-0242ac130002"),
                            FullLink = "https://thanhnien.vn/",
                            ShortLink = "thanhnien"
                        },
                        new
                        {
                            Id = new Guid("11f7fba0-4b45-11eb-ae93-0242ac130002"),
                            Count = 0,
                            CreatedAt = new DateTime(2021, 1, 5, 10, 44, 44, 5, DateTimeKind.Local).AddTicks(756),
                            EmployeeId = new Guid("ffbed34c-4b39-11eb-ae93-0242ac130002"),
                            FullLink = "https://www.uuidgenerator.net/version4",
                            ShortLink = "uuidgen4"
                        });
                });

            modelBuilder.Entity("Entities.Model.RoleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleModel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aeeccc6d-e50f-43d9-92cf-e5b89acb8c83"),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("6f6c4608-4b39-11eb-ae93-0242ac130002"),
                            RoleName = "Employee"
                        });
                });

            modelBuilder.Entity("Entities.Model.EmployeeModel", b =>
                {
                    b.HasOne("Entities.Model.RoleModel", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.Model.LinkDataModel", b =>
                {
                    b.HasOne("Entities.Model.EmployeeModel", "Employee")
                        .WithMany("LinkDatas")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Entities.Model.EmployeeModel", b =>
                {
                    b.Navigation("LinkDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
