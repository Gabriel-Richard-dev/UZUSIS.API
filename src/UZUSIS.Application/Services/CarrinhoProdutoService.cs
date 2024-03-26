using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class CarrinhoProdutoService : BaseService<CarrinhoProduto>, ICarrinhoProdutoService
{
    public CarrinhoProdutoService(INotification notification, IMapper mapper) : base(notification, mapper)
    {
    }
}