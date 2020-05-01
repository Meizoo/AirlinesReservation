using AirlinesReservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AirlinesReservation.DB
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            this.Configuration.LazyLoadingEnabled = false;
            base.Dispose(disposing);
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasRequired(p => p.User)
                .WithMany(p => p.Reservation)
                .HasForeignKey(p => p.UserId)
                .WillCascadeOnDelete(false);

        }
    }
}