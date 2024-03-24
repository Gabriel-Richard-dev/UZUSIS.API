namespace UZUSIS.Application.Contracts.Services;

public interface IAuthService
{
    Task<bool> isAuthenticationValid();
}