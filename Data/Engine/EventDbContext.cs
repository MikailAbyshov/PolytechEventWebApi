using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Engine;

internal sealed class EventDbContext : DbContext, IEventDbContext
{
  public DbSet<Event> Events { get; set; }
  
  public DbSet<EventInfo> EventInfo { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    base.OnConfiguring(optionsBuilder);
    optionsBuilder.UseSnakeCaseNamingConvention();
  }
}