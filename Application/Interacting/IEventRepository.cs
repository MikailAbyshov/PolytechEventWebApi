using Application.Entities;

namespace Application.Interacting;

public interface IEventRepository : IRepositoryBase<EventDto>
{
  public Task<EventDto> GetById(Guid eventId);
}