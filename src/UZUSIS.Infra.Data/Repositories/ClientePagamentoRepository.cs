using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class ClientePagamentoRepository : EntityRepository<ClientePagamento>, IClientePagamentoRepository
{
    public ClientePagamentoRepository(UZUSISContext context) : base(context)
    {
    }
}