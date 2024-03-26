using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class ProdutoService : BaseService<Produto>, IProdutoService 
{

    public ProdutoService(INotification notification, IMapper mapper, IProdutoRepository produtoRepository) : base(notification, mapper)
    {
        _produtoRepository = produtoRepository;
    }

    private readonly IProdutoRepository _produtoRepository;


    public async Task<List<Produto>> Get(string parseName)
    {
        parseName = parseName.Trim().ToLower();
        
        var list = await _produtoRepository.Get();

        var listNomes = list.Where(p => p.Nome.ToLower().Contains(parseName)).ToList();

        return listNomes;
    }
}