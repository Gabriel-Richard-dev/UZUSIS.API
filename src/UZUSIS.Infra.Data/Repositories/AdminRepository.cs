using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public class AdminRepository : EntityRepository<Admin>, IAdminRepository
{
    public AdminRepository(UZUSISContext context) : base(context)
    { }
    
}