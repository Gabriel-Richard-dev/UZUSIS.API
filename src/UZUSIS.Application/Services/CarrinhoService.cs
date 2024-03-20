using AutoMapper;
using UZUSIS.Application.Contracts.Services;

namespace UZUSIS.Application.Services;

public class CarrinhoService : BaseService, ICarrinhoSevice
{
    public CarrinhoService(Notification notification, IMapper mapper) : base(notification, mapper)
    {
    }
}