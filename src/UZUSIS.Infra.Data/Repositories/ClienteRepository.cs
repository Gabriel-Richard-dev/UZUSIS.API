using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class ClienteRepository : EntityRepository<Cliente>, IClienteRepository
{
    public ClienteRepository(UZUSISContext context) : base(context)
    {
        
        
        
        
    }
}