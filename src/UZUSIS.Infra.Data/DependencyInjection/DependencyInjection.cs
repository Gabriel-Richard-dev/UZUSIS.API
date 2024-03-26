using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UZUSIS.Application;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Infra.Data.Repositories;

namespace UZUSIS.Infra.Data.DependencyInjection;

public static class DependencyInjection
{
    public static void AddDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<INotification, Notification>();
        
        //services
        
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<IProdutoService, ProdutoService>();
        
        //repositories
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
    }
}