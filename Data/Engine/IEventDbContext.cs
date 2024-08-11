using Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Data;

public interface IEventDbContext
{
  DbSet<EventDto> Events { get; set; }

  DbSet<TRecord> Set<TRecord>() where TRecord : class;

  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
  
  DatabaseFacade Database { get; }
}