using Microsoft.EntityFrameworkCore;
using TheGreatestApiInTheWorldTribute.Entities.Models;
using TheGreatestApiInTheWorldTribute.Repository.Configuration;

namespace TheGreatestApiInTheWorldTribute.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BandConfiguration());
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
        }

        public DbSet<Band>? Bands { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
