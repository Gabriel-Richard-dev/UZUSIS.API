using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class UsuarioService : BaseService<Usuario>, IUsuarioService
{
    
    public UsuarioService(INotification notification, IMapper mapper,
        IUsuarioRepository usuarioRepository, ICarrinhoSevice carrinhoSevice) : base(notification, mapper)
    {
        _usuarioRepository = usuarioRepository;
    }
    
    private readonly IUsuarioRepository _usuarioRepository;


    public override async Task<Usuario?> Create<UsuarioDTO>(UsuarioDTO dto)
    {
        var userMapped = _mapper.Map<Usuario>(dto);
        
        if (!(await Existis(userMapped)))
        {
            _notification.NotFound();
            return null;
        }

        _notification.AddNotification(userMapped.Validate());

        if (_notification.hasNotification())
        {
            return null;
        }


        var userCreated = await _usuarioRepository.Create(userMapped);

        if (await CommitChanges())
        {
            return userCreated;
        }
        
        _notification.AddNotification("Impossivel criar o cliente!");
        return null;

    }



    public override async Task<bool> CommitChanges()
    {
        if (await _usuarioRepository.UnityOfWork.Commit())
        {
            return true;
        }

        return false;
    }
    
}