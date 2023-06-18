using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject1
{
    public class EfContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        private const string connectionString = "Server=Filip;Database=Filip123;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(connectionString); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Filename = {Path.Combine(Environment.CurrentDirectory, "PracticeDatabase.db")}");
        }

     
    }
}
