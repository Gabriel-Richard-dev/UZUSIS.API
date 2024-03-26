using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UZUSIS.Application.Contracts.Services;
using UZUSIS.Application.DTO;
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

    protected BaseService(INotification notification, IMapper mapper)
    {
        _notification = notification;
        _mapper = mapper;
    }


    public async Task<List<T>?> Get()
    {
        var list = await _repository.Get();

        if (!(await Existis(list.FirstOrDefault())))
        {
            return null;
        }

        return list;
    }

    public async Task<T?> Get(long id)
    {
        var entity = await _repository.Get(id);

        if(!(await Existis(entity)))
        {
            return null;
        }

        
        return entity;

    }
    

    public virtual async Task<T?> Create<DTO>(DTO entitydto) where DTO : BaseDTO
    {
        var entity = _mapper.Map<T>(entitydto);
        entity.Validate();
        
        if ((await Existis(entity)))
        {
            _notification.AddNotification($"{typeof(T)} já existente.");
            return null;
        }
        
        await _repository.Create(entity);
        if (await CommitChanges())
        {
            return null;
        }

        _notification.AddNotification($"Service: Não foi possível criar {typeof(T)}");
        return null;
    }

    public async Task<T?> Update(T entity)
    {
        var entityExists = await _repository.Get(entity.Id);
        
        if ((await Existis(entity)))
        {
            await _repository.Update(entity);

            if (await CommitChanges())
            {
                return entity;
            }

            _notification.AddNotification("Não foi possível atualizar o usuário");
        }
        
        return null;
    }

    public async Task Remove(T entity)
    {
        if (!(await Existis(entity)))
        {
            await _repository.Delete(entity);
        }
    }


    public async Task<bool> Existis(T entity)
    {
        
        var entityExists = await Get(entity.Id);
        
        if (entityExists is null)
        {
            _notification.NotFound();
            return false;
        }

        return true;
    } 
  


public async Task<bool> CommitChanges()
    {
        if (await _repository.UnityOfWork.Commit())
            return true;
        
        return false;
    }

    
    
}