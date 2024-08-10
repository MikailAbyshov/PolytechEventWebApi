using Application.Entities;

namespace Application.Interacting;

public interface IRepositoryBase<in TEntity> 
  where TEntity : IEntityDto
{
  public Task Create(TEntity entity);

  public Task Update(TEntity entity);

  public Task Delete(Guid eventId);
}