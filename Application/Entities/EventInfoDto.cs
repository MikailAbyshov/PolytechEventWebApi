namespace Application.Entities;

public sealed class EventInfoDto : IEntityDto
{
  public Guid Id { get; set; }
  
  public string? EventDescription { get; set; }
  
  public DateTime CreatedAt { get; set; }
  
  public DateTime UpdatedAt { get; set; }
}