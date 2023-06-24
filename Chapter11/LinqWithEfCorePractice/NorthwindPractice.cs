using LinqWithEfCorePractice.ModelsPractice;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class NorthwindPractice : DbContext
{
    public DbSet<Category> Categories { get; set; } = null;
    public DbSet<Product> Products { get; set; } = null;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Filename={Path.Combine(Environment.CurrentDirectory,"Database","NorthwindPractice.db")}");
       
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if((Database.ProviderName is not null) && (Database.ProviderName.Contains("Sqlite")))
        {
            modelBuilder.Entity<Product>().Property(p => p.UnitPrice).HasConversion<double>();
        }
    }
}
