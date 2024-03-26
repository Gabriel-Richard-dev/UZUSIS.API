using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class PagamentoService : BaseService<Pagamento>, IPagamentoService
{
    public PagamentoService(INotification notification, IMapper mapper,
        IPagamentoRepository pagamentoRepository) : base(notification, mapper)
    {
        _pagamentoRepository = pagamentoRepository;
    }

    private readonly IPagamentoRepository _pagamentoRepository;

    
    
    
}