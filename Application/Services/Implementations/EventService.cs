using Application.Interacting;
using Application.Services.Contracts;
using Domain.Entities;

namespace Application.Services.Implementations;

public class EventService(IEventRepository repository) : IEventService 
{
  public async Task<Event> GetById(Guid id)
  {
    return await repository.GetById(id);
  }

  public async Task<Guid> Create(EventInfo info)
  {
    var newEvent = Event.Create(info);

    await repository.Create(newEvent);

    return newEvent.Id;
  }

  public async Task<Event> UpdateInfo(string description, Guid eventId)
  {
    var updatingEvent = await repository.GetById(eventId);
    
    updatingEvent.UpdateInfo(description);

    await repository.Update(updatingEvent);

    return updatingEvent;
  }

  public async Task Delete(Guid id) => await repository.Delete(id);
}