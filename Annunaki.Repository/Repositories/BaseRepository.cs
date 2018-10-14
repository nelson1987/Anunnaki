using Annunaki.Repository.Interfaces;
using System;

namespace Annunaki.Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public abstract void Insert(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract void Delete(int idEntity);
        public abstract void FindById(int idEntity);
        public abstract void FindByFilter(Func<TEntity> filter);
    }
}
