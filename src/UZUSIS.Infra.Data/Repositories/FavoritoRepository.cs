using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class FavoritoRepository: EntityRepository<Favorito>, IFavoritoRepository
{
    public FavoritoRepository(UZUSISContext context) : base(context)
    {
    }
}