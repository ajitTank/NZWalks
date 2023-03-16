using Microsoft.EntityFrameworkCore;
using NZWalks.Models.Domina;

namespace NZWalks.Data
{
    public class ApplicationDb:DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> option):base(option)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulties { get; set; }

    }
}
