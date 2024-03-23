using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class UsuarioRepository : EntityRepository<Admin>, IAdminRepository
{
    public UsuarioRepository(UZUSISContext context) : base(context)
    { }
    
}