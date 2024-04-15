using Microsoft.EntityFrameworkCore;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class CarrinhoRepository : EntityRepository<Carrinho>, ICarrinhoRepository
{
    public CarrinhoRepository(UZUSISContext context) : base(context)
    {
    }


    public async Task SalvarEstado(long carrinhoId)
    {
        
    }

    
}