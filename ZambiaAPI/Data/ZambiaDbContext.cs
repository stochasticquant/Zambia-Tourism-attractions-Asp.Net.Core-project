using Microsoft.EntityFrameworkCore;
using ZambiaAPI.Models.Domain;

namespace ZambiaAPI.Data
{
    public class ZambiaDbContext: DbContext
    {
        // Constructor : we pass the options to the base class
        public ZambiaDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        // DbSet is a collection of entities that will be used to query the database.
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<TourGuide> TourGuides { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TouristAttractions> TouristAttractions { get; set; }
    }
}
