using EmiChoiceTravels.Models;
using Microsoft.EntityFrameworkCore;

namespace EmiChoiceTravels.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Visa> Visas { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
