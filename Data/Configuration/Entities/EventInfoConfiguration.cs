using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration.Entities;

internal sealed class EventInfoConfiguration : IEntityTypeConfiguration<EventInfo> 
{
  public void Configure(EntityTypeBuilder<EventInfo> builder)
  {
    builder
      .Property(ei => ei.EventDescription)
      .IsRequired();
    
    builder
      .Property(ei => ei.CreatedAt)
      .IsRequired();

    builder
      .Property(ei => ei.UpdatedAt)
      .IsRequired();
  }
}