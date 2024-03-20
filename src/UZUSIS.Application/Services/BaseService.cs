using AutoMapper;
using UZUSIS.Application.Contracts.Services;

namespace UZUSIS.Application.Services;

public abstract class BaseService : IBaseService
{
    public BaseService(Notification notification, IMapper mapper)
    {
        _notification = notification;
        _mapper = mapper;
    }

    protected readonly Notification _notification;
    protected readonly IMapper _mapper;

}