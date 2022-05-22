using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext 
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    ID = 1,
                    Name = "Jamaica",
                    shortName = "JM"
                },

                new Country
                {
                    ID = 2,
                    Name = "Cayman",
                    shortName = "CY"
                },

                new Country
                {
                    ID = 3,
                    Name = "England",
                    shortName = "EN"
                },
                
                new Country
                {
                    ID = 4, Name = "Spain", shortName = "SPN"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },

                new Hotel
                {
                    Id = 2,
                    Name = "Grand Palladium",
                    Address = "Mundy",
                    CountryId = 2,
                    Rating = 4.0
                },

                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Suits",
                    Address = "Berkshier",
                    CountryId = 3,
                    Rating = 3.0

                });
        }
    }
}
