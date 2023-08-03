using Microsoft.EntityFrameworkCore;
using SimpleMVC.Models;

namespace SimpleMVC.Data
{
    public class SimpleMvcDbContext :DbContext
    {
      

        public SimpleMvcDbContext(DbContextOptions options): base(options)
        {
            
        }

        public virtual DbSet<Card> Cards { get;set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.CardID).ValueGeneratedOnAdd();
                entity.HasKey(e => e.CardID);
            }
            ); 
        }
    }
}
