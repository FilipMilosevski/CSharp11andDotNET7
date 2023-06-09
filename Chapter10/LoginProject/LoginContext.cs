﻿using LoginProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginProject
{
    public class LoginContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename = {Path.Combine(Environment.CurrentDirectory, "Login.db")}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(r => r.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.Ref_RoleID);
        }
    }
}
