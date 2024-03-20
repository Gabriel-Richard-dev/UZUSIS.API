using AutoMapper;
using UZUSIS.Application.Contracts.Services;

namespace UZUSIS.Application.Services;

public class ClienteService : BaseService, IClienteService
{
    public ClienteService(Notification notification, IMapper mapper) : base(notification, mapper)
    {
    }

    public void teste()
    {
        _notification.AddNotification("teste");
    }
    
}