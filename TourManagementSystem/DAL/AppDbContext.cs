using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using TourManagementSystem.DAL.Models;

namespace TourManagementSystem.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

             modelBuilder.Entity<Booking>()

            .HasOne(b => b.User)

            .WithMany(u => u.Bookings)

            .HasForeignKey(b => b.UserId)

            .IsRequired();


             modelBuilder.Entity<Booking>()

            .HasOne(b => b.Package)

            .WithMany(p => p.Bookings)

            .HasForeignKey(b => b.PackageId)

            .IsRequired();


        }


    }
}
