﻿namespace Core.DataAccess;

public interface IEntityRepository<TEntity, TEntityId> // Repository Design Pattern
{
    public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null);
    

    public TEntity? Get(Func<TEntity, bool> predicate);

    public TEntity Add(TEntity entity);
    public TEntity Update(TEntity entity);
    public TEntity Delete(TEntity entity, bool isSoftDelete = true);
}
