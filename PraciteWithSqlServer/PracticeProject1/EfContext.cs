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


     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Filename  =  {Path.Combine(Environment.CurrentDirectory, "fil.db")}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(c => c.DepartmentName).IsRequired().HasMaxLength(15);
            if(Database.ProviderName?.Contains("SqlServer")?? false)
            {
                modelBuilder.Entity<Employee>().Property(p => p.EmployeeId).HasMaxLength(15);
            }
        }

    }
}
