using System.Data;
using System.Reflection.Metadata;

namespace Domain.Entities;

public sealed class Event : IEntity
{
  private Event(
    Guid id,
    EventInfo info)
  {
    this.Id = id;
    this.Info = info;
  }
  
  public Guid Id { get; }

  public EventInfo Info { get; }

  public static Event Create(EventInfo info)
  {
    var newEvent = new Event(Guid.NewGuid(), info);

    return newEvent;
  }

  public void UpdateInfo(string description)
  {
    this.Info.UpdateInfo(description);
  }
}