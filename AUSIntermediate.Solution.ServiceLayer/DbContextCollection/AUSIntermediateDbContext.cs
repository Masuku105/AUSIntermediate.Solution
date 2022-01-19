using AUSIntermediate.Solution.ServiceLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer
{
    public class AUSIntermediateDbContext : DbContext
    {
       
        public AUSIntermediateDbContext(DbContextOptions<AUSIntermediateDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                              .AddJsonFile("appsettings.json")
                              .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); ;
            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            
            modelBuilder.Entity<User>()
            .HasData(
                new User
                {
                    UserId = 1,
                    Name = "John",
                    Surname = "Doe",
                    DateOfBirth = DateTime.Now,
                    IdentityNumber = "1234567890123",
                    Email = "John@ausafrica.com",
                    Contact = "0761234566"
                },
                new User
                {
                    UserId = 2,
                    Name = "Xolani",
                    Surname = "2",
                    DateOfBirth = DateTime.Now,
                    IdentityNumber = "1234567890123",
                    Email = "xolani@gmail.com",
                    Contact = "0761234566"
                    
                }
             );

            modelBuilder.Entity<Address>()
                            .HasData(
                                new Address
                                {
                                    AddressId = 1,
                                    Country = "South Africa",
                                    Province = "Gauteng",
                                    City = "Midrand",
                                    Suburb = "Midrand",
                                    PostalCode = "01100",
                                    UnitNUmber = "45627",
                                    ComplexName = "Business Complex",
                                    IsResidentialAddress = true,
                                    UserId = 2,
                                  

                                },
                                 new Address
                                 {
                                     AddressId = 2,
                                     Country = "South Africa",
                                     Province = "Kwazulu Natal",
                                     City = "Durban",
                                     Suburb = "Newlands",
                                     PostalCode = "01100",
                                     UnitNUmber = "X1234",
                                     ComplexName = "Curry Road",
                                     IsResidentialAddress = false,
                                     UserId = 2,
                                     
                                 },
                                  new Address
                                  {
                                      AddressId = 3,
                                      Country = "South Africa",
                                      Province = "Gauteng",
                                      City = "Midrand",
                                      Suburb = "Midrand",
                                      PostalCode = "01100",
                                      UnitNUmber = "45627",
                                      ComplexName = "Business Complex",
                                      IsResidentialAddress = true,
                                      UserId = 1,


                                  },
                                 new Address
                                 {
                                     AddressId = 4,
                                     Country = "South Africa",
                                     Province = "Kwazulu Natal",
                                     City = "Durban",
                                     Suburb = "Newlands",
                                     PostalCode = "01100",
                                     UnitNUmber = "X1234",
                                     ComplexName = "Curry Road",
                                     IsResidentialAddress = false,
                                     UserId = 1,

                                 }
                            );


        }
    }
}

