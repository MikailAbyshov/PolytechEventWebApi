using Application.Entities;
using Domain.Entities;

namespace Application.Services.Contracts;

public interface IEventService
{
  public Task<EventDto> GetById(Guid id);

  public Task<Guid> Create(EventInfo info);

  public Task<EventDto> UpdateInfo(string description, Guid eventId);
  
  public Task Delete(Guid id);
}