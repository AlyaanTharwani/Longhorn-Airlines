using System;
using Microsoft.EntityFrameworkCore;

// Update this using statement to include your project name
using spr24_team4_finalproject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection.Emit;

// Make this namespace match your project name
namespace spr24_team4_finalproject.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
            builder.Entity<Tickets>()
                .HasOne(t => t.Flight)
                .WithMany(f => f.Ticket)
                .HasForeignKey(t => t.FlightsID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Enable sensitive data logging
            optionsBuilder.EnableSensitiveDataLogging();

        }

        //Add Dbsets here.  Products is included as an example.  
        //public DbSet<Product> Products { get; set; }
        public DbSet<FlightRoutes> FlightRoute { get; set; }
        public DbSet<Flights> Flight { get; set; }
        public DbSet<Reservations> Reservation { get; set; }
        public DbSet<Tickets> Ticket { get; set; }


    }
}
