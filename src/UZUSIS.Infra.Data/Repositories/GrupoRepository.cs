using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class GrupoRepository : EntityRepository<Grupo>, IGrupoRepository
{
    public GrupoRepository(UZUSISContext context) : base(context)
    {
    }
}