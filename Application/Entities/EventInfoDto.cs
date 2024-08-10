namespace Application.Entities;

public sealed class EventInfoDto : IEntityDto
{
  public string? EventDescription { get; set; }
  
  public DateTime CreatedAt { get; set; }
  
  public DateTime UpdatedAt { get; set; }
}