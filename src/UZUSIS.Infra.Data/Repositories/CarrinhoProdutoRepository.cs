using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class CarrinhoProdutoRepository : EntityRepository<CarrinhoProduto>, ICarrinhoProdutoRepository
{
    public CarrinhoProdutoRepository(UZUSISContext context) : base(context)
    {
    }
}