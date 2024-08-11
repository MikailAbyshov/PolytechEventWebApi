using Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration.Entities;

internal sealed class EventDtoConfiguration : IEntityTypeConfiguration<EventDto>
{
  public void Configure(EntityTypeBuilder<EventDto> builder)
  {
    builder
      .Property(e => e.Id)
      .IsRequired();
    builder
      .Property(e => e.Info)
      .IsRequired();
  }
}