using Microsoft.EntityFrameworkCore;
using MediaCatalog.Models;

namespace MediaCatalog.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Album> Albums => Set<Album>();
    public DbSet<Game> Games => Set<Game>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Movie>().ToTable("Movies");
        modelBuilder.Entity<Album>().ToTable("Albums");
        modelBuilder.Entity<Game>().ToTable("Games");
    }
}