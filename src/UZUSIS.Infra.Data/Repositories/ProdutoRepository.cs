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

 
    public async Task<List<Produto>?> Get(string IdentificadorGrupo)
    {
        var list =_context.Produtos
            .Where(p => p.IdentificadorGrupo
                .Equals(IdentificadorGrupo))
            .AsNoTrackingWithIdentityResolution()
            .ToList();

        return list;

    }
}