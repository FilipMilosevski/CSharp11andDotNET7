//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore.SqlServer;


//namespace EmployeeAndDepartment
//{
//    public class EfContext : DbContext
//    {
//        private const string connectionString = "Server=Filip;Database=EFCore12Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer(connectionString); }
//        public DbSet<Employee> Employees { get; set; }
//        public DbSet<Department> Departments { get; set; }

//    }
//}
