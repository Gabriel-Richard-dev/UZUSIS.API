using AutoMapper;
using UZUSIS.Application.Contracts.Services;

namespace UZUSIS.Application.Services;

public class AdminService : BaseService, IAdminService
{
    public AdminService(Notification notification, IMapper mapper) : base(notification, mapper)
    {
    }
}