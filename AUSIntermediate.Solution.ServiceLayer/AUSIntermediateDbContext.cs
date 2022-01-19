using AUSIntermediate.Solution.ServiceLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSIntermediate.Solution.ServiceLayer
{
    public class AUSIntermediateDbContext : DbContext
    {
        const string connectionString = "Server=ODINDELL1;Database=AUSIntermediateDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        public AUSIntermediateDbContext(DbContextOptions<AUSIntermediateDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
    }
}
