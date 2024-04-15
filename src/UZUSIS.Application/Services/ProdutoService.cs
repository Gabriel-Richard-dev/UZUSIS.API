using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class ProdutoService : BaseService<Produto>, IProdutoService 
{

    public ProdutoService(INotification notification, IMapper mapper,
        IProdutoRepository produtoRepository) : base(notification, mapper)
    {
        _produtoRepository = produtoRepository;
    }

    private readonly IProdutoRepository _produtoRepository;


    
    
}