using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public class GrupoService : BaseService<Grupo>, IGrupoService
{
    public GrupoService(INotification notification, IMapper mapper) : base(notification, mapper)
    {
    }
    
}