using UZUSIS.Application.DTO;

namespace UZUSIS.Application.Contracts.Services;

public interface ITokenService : IBaseService
{
    string GenerateToken(PessoaDTO pessoa);
}