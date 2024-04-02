using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface IProdutoService : IBaseService<Produto>
{
    Task<List<List<Produto>>?> Get(string parseName);
    Task<List<Produto>?> GetGroup(string identificadorGrupo);

    Task<List<List<Produto>>?> GetGroup();
}