using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class UsuarioService : BaseService, IUsuarioService
{
    
    public UsuarioService(Notification notification, IMapper mapper, IUsuarioRepository usuarioRepository) : base(notification, mapper)
    {
        _usuarioRepository = usuarioRepository;
    }

    private readonly IUsuarioRepository _usuarioRepository;

    public async Task<List<Usuario>?> GetUser()
    {
        var list = await _usuarioRepository.Get();

        
        
        return list;
    }

    public async Task<Usuario?> GetUser(long id)
    {
        var admin = await _usuarioRepository.Get(id);
        
        if (admin is null)
        {
            _notification.NotFound();
            return null;
        }

        return admin;
    }
    
    
    

}