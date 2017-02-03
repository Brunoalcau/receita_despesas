using System.Collections.Generic;

namespace Fina.AvaliacaoTecnica.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Remove(TEntity entity);

        void RemoveAll(IList<int> ids);
    }
}
