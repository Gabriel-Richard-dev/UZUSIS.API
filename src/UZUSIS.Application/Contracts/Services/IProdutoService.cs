using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface IProdutoService : IBaseService<Produto>
{
    Task<List<Produto>> Get(string parseName);
}