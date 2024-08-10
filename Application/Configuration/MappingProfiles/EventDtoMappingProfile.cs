using Application.Entities;
using AutoMapper;
using Domain.Entities;

namespace Application.Configuration.MappingProfiles;

internal sealed class EventDtoMappingProfile : Profile
{
  public EventDtoMappingProfile()
  {
    CreateMap<Event, EventDto>().ReverseMap();
  }
}