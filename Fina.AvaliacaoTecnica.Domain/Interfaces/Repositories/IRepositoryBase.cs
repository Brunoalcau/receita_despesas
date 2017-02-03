using System.Collections.Generic;

namespace Fina.AvaliacaoTecnica.Interfaces.Repositories
{
    public  interface IRepositoryBase<TEntity> where TEntity: class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        TEntity GetById(int id);
        
        IEnumerable<TEntity>GetAll();

        void RemoveAll(IList<int> entitys);

        void Remove(TEntity entity);

        void Dispose();
    }
}
