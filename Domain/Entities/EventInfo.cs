namespace Domain.Entities;

public sealed class EventInfo
{
  private EventInfo(
    string eventDescription
    )
  {
    this.EventDescription = eventDescription;
  }
  
  public string? EventDescription { get; private set; }
  
  public DateTime CreatedAt { get; private set; }
  
  public DateTime UpdatedAt { get; private set; }

  public static EventInfo Create(string eventDescription)
  {
    var info = new EventInfo(eventDescription);
    info.CreatedAt = DateTime.UtcNow;
    info.UpdatedAt = DateTime.UtcNow;
    return info;
  }

  public void UpdateInfo(string description)
  {
    this.EventDescription = description;
    this.UpdatedAt = DateTime.Now;
  }
}