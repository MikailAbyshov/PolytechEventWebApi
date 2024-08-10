using Domain.Entities;

namespace Application.Interacting;

public interface IEventRepository : IRepositoryBase<Event>
{
  public Task<Event> GetById(Guid eventId);
}