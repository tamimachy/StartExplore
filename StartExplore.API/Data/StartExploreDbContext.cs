using Microsoft.EntityFrameworkCore;
using StartExploreAPI.Models.Domain;

namespace StartExploreAPI.Data
{
    public class StartExploreDbContext : DbContext
    {
        public StartExploreDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
