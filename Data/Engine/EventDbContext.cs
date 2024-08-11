using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

internal sealed class EventDbContext : DbContext, IEventDbContext
{
  public DbSet<EventDto> Events { get; set; }
  
}