using Application.Interacting;
using Application.Services.Contracts;
using Domain.Entities;

namespace Application.Services.Implementations;

/// <summary>
/// Сервис для работы с событиями
/// </summary>
/// <param name="repository"></param>
public class EventService(IEventRepository repository) : IEventService 
{
  /// <summary>
  /// Получить событие по Id
  /// </summary>
  /// <param name="id">Id события</param>
  public async Task<Event> GetById(Guid id)
  {
    return await repository.GetById(id);
  }

  /// <summary>
  /// Создать событие
  /// </summary>
  public async Task<Guid> Create(EventInfo info)
  {
    var newEvent = Event.Create(info);

    await repository.Create(newEvent);

    return newEvent.Id;
  }

  /// <summary>
  /// Обновить событие
  /// </summary>
  /// <param name="description">Описание для обновления</param>
  /// <param name="eventId">Id события</param>
  public async Task<Event> UpdateInfo(string description, Guid eventId)
  {
    var updatingEvent = await repository.GetById(eventId);
    
    updatingEvent.UpdateInfo(description);

    await repository.Update(updatingEvent);

    return updatingEvent;
  }

  /// <summary>
  /// Удалить событие
  /// </summary>
  /// <param name="id">Id удаляемого события</param>
  public async Task Delete(Guid id) => await repository.Delete(id);
}