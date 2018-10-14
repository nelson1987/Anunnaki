using System;

namespace Annunaki.Repository.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int idEntity);
        void FindById(int idEntity);
        void FindByFilter(Func<TEntity> filter);
    }
}
