using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class ProdutoService : BaseService<Produto>, IProdutoService 
{

    public ProdutoService(INotification notification, IMapper mapper,
        IProdutoRepository produtoRepository) : base(notification, mapper, produtoRepository)
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

    public async Task<List<Produto>?> Search(string search)
    {
        var produtos = await _produtoRepository.Get(search);

        if (produtos.Count > 0)
        {
            return produtos;
        }

        return null;
    }


    protected override async Task<bool> Existis(Produto produto)
    {
        if ((await Search(produto.Nome)) is not null)
        {
            return true;
        }

        return false;
    }
}