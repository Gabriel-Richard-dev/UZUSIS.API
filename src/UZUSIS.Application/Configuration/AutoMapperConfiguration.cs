using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UZUSIS.Application.DTO;
using UZUSIS.Application.DTO.Seletor;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Configuration;

public static class AutoMapperConfiguration
{
     public static void ConfigureMappings(this IServiceCollection services)
     {
          var autoMapperConfig = new MapperConfiguration(options =>
          {
               options.CreateMap<Usuario, UsuarioDTO>().ReverseMap();
               options.CreateMap<Produto, ProdutoDTO>().ReverseMap();
               options.CreateMap<Seletor, SeletorDTO>().ReverseMap();
               options.CreateMap<SeletorOption, SeletorOptionDTO>().ReverseMap();
               options.CreateMap<Atributo, AtributoDTO>().ReverseMap();
               options.CreateMap<AtributoOption, AtributoOptionDTO>().ReverseMap();
          });
          services.AddSingleton(autoMapperConfig.CreateMapper());
     }
}