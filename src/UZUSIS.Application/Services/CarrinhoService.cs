using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
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

    public async Task<Carrinho?> CreateCarrinho(Usuario? user)
    {

        if (user is null)
        {
            _notification.NotFound();
            return null;
        }
        
        
        var carrinho = new CarrinhoDTO()
        {
            Cliente = user,
            UserId = user.Id
        };

        return await Create(carrinho);

    }
}