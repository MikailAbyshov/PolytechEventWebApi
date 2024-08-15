using Application.Entities;
using Application.Interacting;
using Application.Services.Contracts;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.Implementations;

/// <summary>
/// Сервис для работы с событиями
/// </summary>
public class EventService(
  IEventRepository repository,
  IMapper mapper) : IEventService 
{
  /// <summary>
  /// Получить событие по Id
  /// </summary>
  /// <param name="id">Id события</param>
  public async Task<EventDto> GetById(Guid id)
  {
    var eventModel = await repository.GetById(id);

    var eventDto = mapper.Map<Event, EventDto>(eventModel);

    return eventDto;
  }

  /// <summary>
  /// Создать событие
  /// </summary>
  public async Task<Guid> Create(EventInfo info, string title)
  {
    var newEvent = Event.Create(info, title);

    await repository.Create(newEvent);

    return newEvent.Id;
  }

  /// <summary>
  /// Обновить событие
  /// </summary>
  /// <param name="description">Описание для обновления</param>
  /// <param name="eventId">Id события</param>
  public async Task<EventDto> UpdateInfo(string description, Guid eventId)
  {
    var updatingEvent = await repository.GetById(eventId);
    
    updatingEvent.UpdateInfo(description);

    await repository.Update(updatingEvent);

    var updatingEventDto = mapper.Map<Event, EventDto>(updatingEvent);

    return updatingEventDto;
  }

  /// <summary>
  /// Удалить событие
  /// </summary>
  /// <param name="id">Id удаляемого события</param>
  public async Task Delete(Guid id) => await repository.Delete(id);
}