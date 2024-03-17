﻿using Microsoft.EntityFrameworkCore;
using UZUSIS.Domain.Contracts;
using UZUSIS.Domain.Contracts.Repositories;
using UZUSIS.Domain.Entities;
using UZUSIS.Infra.Data.Context;

namespace UZUSIS.Infra.Data.Repositories;

public abstract class EntityRepository<T> : IEntityRepository<T> where T : Entity
{
    protected EntityRepository(UZUSISContext context)
    {
        
        _context = context;
        _dbSet = _context.Set<T>();
    }

    private readonly UZUSISContext _context;
    private readonly DbSet<T> _dbSet;
    private IUnityOfWork UnityOfWork => _context;
    
    
    
    public virtual async Task<T> Create(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public virtual async Task Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public virtual async Task<T> Update(T entity)
    {
        _dbSet.Entry(entity).State = EntityState.Detached;
        _dbSet.Update(entity);
        return entity;
    }

    public virtual async Task<List<T>>? Get()
    {
        return await _dbSet
            .AsNoTrackingWithIdentityResolution()
            .ToListAsync();
    }

    public virtual async Task<T?> Get(long id)
    {
        var list = (await Get());
        var returnEntity = list
            .Where(entity => entity.Id == id)
            .ToList()
            .FirstOrDefault();

        return returnEntity;

    }
}