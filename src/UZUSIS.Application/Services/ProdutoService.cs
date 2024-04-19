using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
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

    public async Task<List<Produto>> Get()
    {
        throw new NotImplementedException();
    }
    
    public async Task<List<Produto>> Get(string parseName)
    {
        return await _produtoRepository.Get(parseName);
    }

    public Task<List<Produto>> Search(SearchProdutoDTO search)
    {
        throw new NotImplementedException();
    }
}