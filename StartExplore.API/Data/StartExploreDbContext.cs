using Microsoft.EntityFrameworkCore;
using StartExploreAPI.Models.Domain;

namespace StartExploreAPI.Data
{
    public class StartExploreDbContext : DbContext
    {
        public StartExploreDbContext(DbContextOptions<StartExploreDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("896257d8-e4ad-4935-8b44-6150aa6df470"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("2bae93b2-72a0-469e-913b-d6f722637692"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("30af42c1-0537-40be-990f-dce77c111851"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("14dc09b4-8ee1-407a-8970-8aaaa8b030f9"),
                    Name = "Tamima Chy",
                    Code = "TC",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("5c665ed5-f805-4025-a9d8-f569d895a8ce"),
                    Name = "Bay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("56b4d807-535c-46b7-9a2e-421ca3f1680f"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("51ea1d8b-b86f-4f95-bdf0-82561b849aa4"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("8d62d14a-867b-432b-99ed-198eda6047bc"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
