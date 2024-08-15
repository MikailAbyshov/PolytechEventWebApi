using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration.Entities;

internal sealed class EventConfiguration : IEntityTypeConfiguration<Event>
{
  public void Configure(EntityTypeBuilder<Event> builder)
  {
    //TODO: Индекс на поле имени
    
    builder
      .Property(e => e.Id)
      .IsRequired();
    
    builder
      .Property(e => e.Info)
      .IsRequired();
    
    builder
      .Property(e => e.Title)
      .IsRequired();
  }
}