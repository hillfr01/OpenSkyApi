using Lightman.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Lightman.Mvc
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Airport>().ToTable("Airports");
        }
    }
}
