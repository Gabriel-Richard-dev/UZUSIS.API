using Microsoft.Extensions.Configuration;
using UZUSIS.Application.DTO;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface ITokenService
{
    string GenerateToken(UsuarioDTO usuario);
}