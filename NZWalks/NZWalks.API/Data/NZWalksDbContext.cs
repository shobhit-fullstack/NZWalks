using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    // always inherits from the base class and takes the namespace "Microsoft.EntityFrameworkCore"
    // short cut for adding namespace ctrl + . (dot)
    public class NZWalksDbContext: DbContext  
    {
        // creating constructor using short cut ctor tab to pass the dbcontext options which takes the class 
        // and base options in the last after the colon
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {

        }

        // now creating properties of DB set types..
        // With this DBSet will be telling the entity framework to create table for us in database if doesn't exists...
        public DbSet<Region> Regions { get; set; } 
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalksDifficulty { get; set; }

    }
}
