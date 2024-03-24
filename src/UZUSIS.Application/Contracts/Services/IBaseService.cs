using UZUSIS.Domain.Entities;

namespace UZUSIS.Application.Contracts.Services;

public interface IBaseService<T> where T : Entity
{
    Task<List<T>?> Get();
    Task<T?> Get(long id);
    Task<T> Create();

    Task<T> Update(T entity);
    Task Remove(T entity);
}