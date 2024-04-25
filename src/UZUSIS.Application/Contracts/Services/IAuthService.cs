using UZUSIS.Application.DTO;
using UZUSIS.Application.DTO.Admin;

namespace UZUSIS.Application.Contracts.Services;

public interface IAuthService
{
    Task<bool> IsAuthenticationValid(AdminLoginDTO loginDto);
    Task<bool> IsAuthenticationValid(UserLoginDTO loginDto);
}