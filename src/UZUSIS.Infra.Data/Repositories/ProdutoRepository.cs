using Microsoft.EntityFrameworkCore;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class ProdutoRepository : EntityRepository<Produto>, IProdutoRepository
{
    public ProdutoRepository(UZUSISContext context) : base(context)
    {
        
    }


    public Task<List<Produto>> Get(string parseName)
    {
        var list = _context.Produtos.AsNoTrackingWithIdentityResolution()
            .Where(p => p.Nome.ToLower().Equals(parseName.ToLower())).ToListAsync();

        return list;
    }
}