using UZUSIS.Domain.Entities;

namespace UZUSIS.Domain.Contracts.Repositories;

public interface IEntityRepository<T> where T : Entity
{
    Task<T> Create(T entity);
    Task Delete(T entity);
    Task<T> Update(T entity);
    Task<List<T>?> Get();
    Task<T?> Get(long id);

    IUnityOfWork UnityOfWork { get; }
}