using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class CarrinhoService : BaseService<Carrinho>, ICarrinhoSevice
{
    public CarrinhoService(INotification notification, IMapper mapper,
        ICarrinhoRepository carrinhoRepository) : base(notification, mapper)
    {
        _carrinhoRepository = carrinhoRepository;
    }

    private readonly ICarrinhoRepository _carrinhoRepository;
    
    
    
    
    
}