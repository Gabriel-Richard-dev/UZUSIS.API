using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class ProdutoService : BaseService<Produto>, IProdutoService 
{

    public ProdutoService(INotification notification, IMapper mapper,
        IProdutoRepository produtoRepository, IGrupoRepository grupoRepository) : base(notification, mapper)
    {
        _produtoRepository = produtoRepository;
        _grupoRepository = grupoRepository;
    }

    private readonly IProdutoRepository _produtoRepository;
    private readonly IGrupoRepository _grupoRepository;


    public async Task<List<List<Produto>>?> Get(string parseName)
    {
        parseName = parseName.Trim().ToLower();
        
        var listGroups = await GetGroup();
        List<List<Produto>> Grupos = new();
        
        foreach (var grupos in listGroups)
        {
            foreach (var produto in grupos)
            {
                if (produto.Nome.ToLower().Contains(parseName))
                {
                    Grupos.Add(grupos);
                    break;
                }
            } 
        }

        return Grupos;

    }
    public async Task<List<Produto>?> GetGroup(string identificadorGrupo)
    {
        var list = await _produtoRepository.Get(identificadorGrupo);
        return list;
    }


    public async Task<List<List<Produto>>?> GetGroup()
    {
        var groups = await _grupoRepository.Get();
        List<List<Produto>> Grupos = new List<List<Produto>>();
        
        foreach (var grupo in groups)
        {
            var listGrupo = await GetGroup(grupo.IdentificadorGrupo);
            if (listGrupo is null)
            {
                _notification.NotFound();
                return null;
            }
            Grupos.Add(listGrupo);
        }

        return Grupos;
    }
    
    
}