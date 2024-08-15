using Application.Interacting;
using Data.Engine;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

internal abstract class RepositoryBase<TRecord>(IEventDbContext dbContext) 
  : IRepositoryBase<TRecord> 
  where TRecord : class, IEntity
{
  public async Task Create(TRecord entity)
  {
    dbContext
      .Set<TRecord>()
      .Add(entity);

    await dbContext
      .SaveChangesAsync();
  }

  public async Task Update(TRecord entity)
  {
    dbContext
      .Set<TRecord>()
      .Update(entity);

    await dbContext
      .SaveChangesAsync();
  }

  public async Task Delete(Guid entityId)
  {
    //TODO: создать своё исключение для фильтра
    
    var entity = await dbContext.Set<TRecord>()
      .FirstOrDefaultAsync(e => e.Id == entityId) ?? throw new Exception();

    dbContext.Set<TRecord>().Remove(entity);

    await dbContext.SaveChangesAsync();
  }
}