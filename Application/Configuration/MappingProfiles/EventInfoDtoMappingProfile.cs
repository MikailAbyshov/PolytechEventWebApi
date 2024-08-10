using Application.Entities;
using AutoMapper;
using Domain.Entities;

namespace Application.Configuration.MappingProfiles;

internal sealed class EventInfoDtoMappingProfile : Profile
{
  public EventInfoDtoMappingProfile()
  {
    CreateMap<EventInfoDto, EventInfo>().ReverseMap();
  }
}