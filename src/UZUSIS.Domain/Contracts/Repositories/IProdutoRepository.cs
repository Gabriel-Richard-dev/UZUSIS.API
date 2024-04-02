using UZUSIS.Domain.Entities;

namespace UZUSIS.Domain.Contracts.Repositories;

public interface IProdutoRepository : IEntityRepository<Produto>
{
    Task<List<Produto>?> Get(string IdentificadorGrupo);
}