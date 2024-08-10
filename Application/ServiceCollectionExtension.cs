using Application.Services.Contracts;
using Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
  
public static class ServiceCollectionExtension
{
  public static void AddServices(this IServiceCollection services)
  {
    services.AddTransient<IEventService, EventService>();
    services.AddAutoMapper(typeof(ServiceCollectionExtension).Assembly);
  }
}