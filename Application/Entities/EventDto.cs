namespace Application.Entities;

public sealed class EventDto : IEntityDto
{
  public Guid Id { get; set; }

  public EventInfoDto? Info { get; set; }
}