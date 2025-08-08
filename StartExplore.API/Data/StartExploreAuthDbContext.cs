using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StartExplore.API.Data
{
    public class StartExploreAuthDbContext : IdentityDbContext
    {
        public StartExploreAuthDbContext(DbContextOptions<StartExploreAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "aa6153fa-c395-4318-895f-901423c80b16";
            var writerRoleId = "6b721878-96e7-4fe9-af26-ad998802d142";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
