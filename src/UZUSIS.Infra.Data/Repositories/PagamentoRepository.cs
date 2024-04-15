using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class PagamentoRepository : EntityRepository<Pagamento>, IPagamentoRepository
{
    public PagamentoRepository(UZUSISContext context) : base(context)
    {
    }
    
}