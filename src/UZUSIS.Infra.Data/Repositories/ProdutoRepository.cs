using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class ProdutoRepository : EntityRepository<Produto>, IProdutoRepository
{
    public ProdutoRepository(UZUSISContext context) : base(context)
    {
    }
}