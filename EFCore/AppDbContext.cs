using System;
using Microsoft.EntityFrameworkCore;
using SampleEFMySql.EFCore.Entities;

namespace SampleEFMySql.EFCore
{
    public class AppDbContext : DbContext
    {
        public DbSet<Invoice> Invoice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=sampledb;user=root;password=mySql1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Vkn).IsRequired();
                entity.Property(e => e.TotalPrice).IsRequired();
            });
        }
    }
}
