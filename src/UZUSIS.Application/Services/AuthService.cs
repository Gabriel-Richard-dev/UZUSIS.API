using Microsoft.Extensions.Configuration;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
using UZUSIS.Application.DTO.Admin;

namespace UZUSIS.Application.Services;

public class AuthService : IAuthService
{
    private readonly IConfiguration _configuration;
    private readonly INotification _notification;
    public AuthService(IConfiguration configuration, INotification notification)
    {
        _configuration = configuration;
        _notification = notification;
    }
    public async Task<bool> IsAuthenticationValid(AdminLoginDTO loginDto)
    {
        
        var emailAdmin = _configuration.GetSection("AdminCredentials")["Email"];
        var passwordAdmin = _configuration.GetSection("AdminCredentials")["Password"];

        if (!(loginDto.Email.Equals(emailAdmin) && loginDto.Password.Equals(passwordAdmin)))
        {
            _notification.AddNotification("Credenciais inválidas.");
            return false;
        }

        return true;
    }

    public Task<bool> IsAuthenticationValid(UserLoginDTO loginDto)
    {
        throw new NotImplementedException();

    }
}