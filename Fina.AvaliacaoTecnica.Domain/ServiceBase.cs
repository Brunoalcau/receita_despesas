using Fina.AvaliacaoTecnica.Domain.Interfaces.Services;
using Fina.AvaliacaoTecnica.Interfaces.Repositories;
using System.Collections.Generic;

namespace Fina.AvaliacaoTecnica.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> respositoryBase)
        {
            _repositoryBase = respositoryBase;
        }

        public void Add(TEntity entity)
        {
            _repositoryBase.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public void Update(TEntity entity)
        {
            _repositoryBase.Update(entity);
        }

        public void RemoveAll(IList<int> ids)
        {
            _repositoryBase.RemoveAll(ids);
        }

        public void Remove(TEntity entity)
        {
            _repositoryBase.Remove(entity);    
        }
    }
}
