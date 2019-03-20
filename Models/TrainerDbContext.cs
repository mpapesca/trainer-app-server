using System;
using Microsoft.EntityFrameworkCore;

namespace trainer_app_server.Models
{
    public class TrainerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=trainer_db;Username=postgres;Password=docker;");
        }
    }
}