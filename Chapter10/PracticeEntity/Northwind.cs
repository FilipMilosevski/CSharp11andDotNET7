using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connection = $"FileName = {path}";

        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Connection {connection}");
        ForegroundColor = previousColor;
        WriteLine("filip");
        WriteLine("sabota");

        optionsBuilder.UseSqlite(connection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().Property(c => c.CategoryName).IsRequired().HasMaxLength(15);

        if (Database.ProviderName?.Contains("SqLite") ?? (false))
        {
            modelBuilder.Entity<Product>().Property(p => p.Cost).HasConversion<double>();
        }
    }
}
