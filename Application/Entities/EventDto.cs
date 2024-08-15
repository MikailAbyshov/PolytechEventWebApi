namespace Application.Entities;

public sealed class EventDto : IEntityDto
{
  public Guid Id { get; set; }
  
  public string Title { get; set; } = String.Empty;

  public EventInfoDto? Info { get; set; }
}