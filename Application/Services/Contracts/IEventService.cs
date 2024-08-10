using Domain.Entities;

namespace Application.Services.Contracts;

public interface IEventService
{
  public Task<Event> GetById(Guid id);

  public Task<Guid> Create(EventInfo info);

  public Task<Event> UpdateInfo(string description, Guid eventId);
  
  public Task Delete(Guid id);
}