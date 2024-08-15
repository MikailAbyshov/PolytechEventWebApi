using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Data.Engine;

public interface IEventDbContext
{
  DbSet<Event> Events { get; set; }
  
  DbSet<EventInfo> EventInfo { get; set; }

  DbSet<TRecord> Set<TRecord>() where TRecord : class;

  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
  
  DatabaseFacade Database { get; }
}