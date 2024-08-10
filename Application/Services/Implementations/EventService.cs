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
    return await repository.GetById(id);
  }

  /// <summary>
  /// Создать событие
  /// </summary>
  public async Task<Guid> Create(EventInfo info)
  {
    var newEvent = Event.Create(info);

    var eventDto = mapper.Map<Event, EventDto>(newEvent);

    await repository.Create(eventDto);

    return eventDto.Id;
  }

  /// <summary>
  /// Обновить событие
  /// </summary>
  /// <param name="description">Описание для обновления</param>
  /// <param name="eventId">Id события</param>
  public async Task<EventDto> UpdateInfo(string description, Guid eventId)
  {
    var updatingEventDto = await repository.GetById(eventId);

    var updatingEvent = mapper.Map<EventDto, Event>(updatingEventDto);
    
    updatingEvent.UpdateInfo(description);

    updatingEventDto = mapper.Map(updatingEvent, updatingEventDto);

    await repository.Update(updatingEventDto);

    return updatingEventDto;
  }

  /// <summary>
  /// Удалить событие
  /// </summary>
  /// <param name="id">Id удаляемого события</param>
  public async Task Delete(Guid id) => await repository.Delete(id);
}