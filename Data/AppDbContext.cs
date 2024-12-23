using Microsoft.EntityFrameworkCore;
using SampleDotnetCoreWebAPI.Models;

namespace SampleDotnetCoreWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { base.OnModelCreating(modelBuilder); modelBuilder.Entity<User>().HasKey(u => u.Id); }
    }
}
