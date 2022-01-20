﻿// <auto-generated />
using System;
using AUSIntermediate.Solution.ServiceLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AUSIntermediate.Solution.ServiceLayer.Migrations
{
    [DbContext(typeof(AUSIntermediateDbContext))]
    [Migration("20220120080248_removecompanyid3")]
    partial class removecompanyid3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ComplexName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsResidentialAddress")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suburb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitNUmber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Midrand",
                            ComplexName = "Business Complex",
                            Country = "South Africa",
                            IsResidentialAddress = true,
                            PostalCode = "01100",
                            Province = "Gauteng",
                            Suburb = "Midrand",
                            UnitNUmber = "45627",
                            UserId = 2
                        },
                        new
                        {
                            AddressId = 2,
                            City = "Durban",
                            ComplexName = "Curry Road",
                            Country = "South Africa",
                            IsResidentialAddress = false,
                            PostalCode = "01100",
                            Province = "Kwazulu Natal",
                            Suburb = "Newlands",
                            UnitNUmber = "X1234",
                            UserId = 2
                        },
                        new
                        {
                            AddressId = 3,
                            City = "Midrand",
                            ComplexName = "Business Complex",
                            Country = "South Africa",
                            IsResidentialAddress = true,
                            PostalCode = "01100",
                            Province = "Gauteng",
                            Suburb = "Midrand",
                            UnitNUmber = "45627",
                            UserId = 1
                        },
                        new
                        {
                            AddressId = 4,
                            City = "Durban",
                            ComplexName = "Curry Road",
                            Country = "South Africa",
                            IsResidentialAddress = false,
                            PostalCode = "01100",
                            Province = "Kwazulu Natal",
                            Suburb = "Newlands",
                            UnitNUmber = "X1234",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BusinessType")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.EmployeeDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Contact = "0761234566",
                            DateOfBirth = new DateTime(2022, 1, 20, 10, 2, 47, 562, DateTimeKind.Local).AddTicks(6916),
                            Email = "John@ausafrica.com",
                            IdentityNumber = "1234567890123",
                            Name = "John",
                            Surname = "Doe"
                        },
                        new
                        {
                            UserId = 2,
                            Contact = "0761234566",
                            DateOfBirth = new DateTime(2022, 1, 20, 10, 2, 47, 563, DateTimeKind.Local).AddTicks(9293),
                            Email = "xolani@gmail.com",
                            IdentityNumber = "1234567890123",
                            Name = "Xolani",
                            Surname = "2"
                        });
                });

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.Address", b =>
                {
                    b.HasOne("AUSIntermediate.Solution.ServiceLayer.Models.Company", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CompanyId");

                    b.HasOne("AUSIntermediate.Solution.ServiceLayer.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.Company", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("AUSIntermediate.Solution.ServiceLayer.Models.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}