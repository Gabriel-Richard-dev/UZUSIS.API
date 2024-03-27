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
        IUsuarioRepository usuarioRepository) : base(notification, mapper)
    {
        _usuarioRepository = usuarioRepository;
    }
    
    private readonly IUsuarioRepository _usuarioRepository;

    
}