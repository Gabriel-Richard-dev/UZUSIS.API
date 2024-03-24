using UZUSIS.Application.DTO;

namespace UZUSIS.Application.Contracts.Services;

public interface ITokenService
{
    string GenerateToken(UsuarioDTO usuario);
}