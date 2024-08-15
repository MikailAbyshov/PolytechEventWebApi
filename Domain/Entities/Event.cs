namespace Domain.Entities;

public sealed class Event : IEntity
{
  private Event(
    Guid id,
    string title,
    EventInfo info)
  {
    this.Id = id;
    this.Title = title;
    this.Info = info;
  }
  
  public string Title { get; private set; }
  
  public Guid Id { get; }

  public EventInfo Info { get; }

  public static Event Create(EventInfo info, string title) 
    => new(Guid.NewGuid(), title, info);

  public void UpdateInfo(string description)
  {
    this.Info.UpdateInfo(description);
  }

  public void UpdateTitle(string title)
  {
    this.Title = title;
  }
}