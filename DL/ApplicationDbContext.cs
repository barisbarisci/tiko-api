using Microsoft.EntityFrameworkCore;
using TikoAPI.Models;

namespace TikoAPI.DL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<House> Houses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity => { entity.ToTable("cities"); });
            modelBuilder.Entity<Agent>(entity => { entity.ToTable("agents"); });
            modelBuilder.Entity<House>(entity => { entity.ToTable("houses"); });
        }
    }
}