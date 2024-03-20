namespace UZUSIS.Application.Contracts.Services;

public interface IAuthService : IBaseService
{
    Task<bool> isAuthenticationValid();
}