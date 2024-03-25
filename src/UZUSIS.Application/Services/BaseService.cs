using AutoMapper;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Services;

public abstract class BaseService<T> : IBaseService<T> where T : Entity
{
    
    public BaseService(INotification notification, IMapper mapper,
        IEntityRepository<T> repository)
    {
        _notification = notification;
        _mapper = mapper;
        _repository = repository;
    }

    internal readonly INotification _notification;
    protected readonly IMapper _mapper;
    private readonly IEntityRepository<T> _repository;

    protected BaseService(Notification notification, IMapper mapper)
    {
        _notification = notification;
        _mapper = mapper;
    }


    public async Task<List<T>?> Get()
    {
        var list = await _repository.Get();
        
        if (list[0] is null)
        {
            _notification.NotFound();
            return null;
        }

        return list;
    }

    public async Task<T?> Get(long id)
    {
        var entity = await _repository.Get(id);

        if (entity is null)
        {
            _notification.NotFound();
            return null;
        }

        return entity;

    }

    public async Task<T> Create()
    {
        // _repository.Create(new Usuario());
        if (await CommitChanges())
        {
            return null;
        }

        _notification.AddNotification("Service: Não foi possível criar o usuário");
        return null;
    }

    public async Task<T> Update(T entity)
    {
        var entityExists = await _repository.Get(entity.Id);
        
        if(entityExists is not null)
        {
            await _repository.Update(entity);

            if (await CommitChanges())
            {
                return entity;
            }

            _notification.AddNotification("Não foi possível atualizar o usuário");
        }

        _notification.NotFound();
        return null;
    }

    public async Task Remove(T entity)
    {
        var entityExists = await Get(entity.Id);

        if (entityExists is null)
        {
            _notification.NotFound();
            return;
        }

        await _repository.Delete(entity);

    }


    public async Task<bool> CommitChanges()
    {
        if (await _repository.UnityOfWork.Commit())
            return true;
        
        return false;
    }

    
    
}