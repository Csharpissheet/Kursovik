    using CharityWebServer2.Models;
    // Data/AppDbContext.cs
    using Microsoft.EntityFrameworkCore;
namespace CharityWebServer2.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Registr { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Registr");
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Id).HasColumnName("id");
            modelBuilder.Entity<User>().Property(u => u.Login).HasColumnName("login");
            modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("password");
        }
    }
}
