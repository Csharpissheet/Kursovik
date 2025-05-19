    using CharityWebServer2.Models;
    // Data/AppDbContext.cs
    using Microsoft.EntityFrameworkCore;
namespace CharityWebServer2.Data
{
    public class AppDbContext1 : DbContext
    {
        public AppDbContext1(DbContextOptions<AppDbContext1> options1) : base(options1) { }

        public DbSet<Donations> Donations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donations>().ToTable("Donations");
        }
    }
}
