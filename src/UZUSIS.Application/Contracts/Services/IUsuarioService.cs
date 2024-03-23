using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface IAdminService : IBaseService
{
    Task<List<Admin>?> GetAdmin();
    Task<Admin?> GetAdmin(long id);
}