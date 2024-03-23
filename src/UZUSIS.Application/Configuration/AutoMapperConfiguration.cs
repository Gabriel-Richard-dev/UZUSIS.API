using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UZUSIS.Application.DTO;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Configuration;

public static class AutoMapperConfiguration
{
     public static void ConfigureMappings(this IServiceCollection services)
     {
          var AutoMapperConfig = new MapperConfiguration(options =>
          {
               options.CreateMap<Usuario, ClienteDTO>().ReverseMap();
          });
          services.AddSingleton(AutoMapperConfig.CreateMapper());
     }
}