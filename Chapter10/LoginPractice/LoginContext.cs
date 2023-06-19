using Microsoft.EntityFrameworkCore;

namespace LoginPractice
{
    public class LoginContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename = {Path.Combine(Environment.CurrentDirectory, "Login Filip Database.db")}");
        }


    }
}
