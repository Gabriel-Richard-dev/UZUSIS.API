using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface IUsuarioService : IBaseService
{
    Task<List<Usuario>?> GetUser();
    Task<Usuario?> GetUser(long id);
}