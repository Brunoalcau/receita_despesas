using Fina.AvaliacaoTecnica.Data;
using Fina.AvaliacaoTecnica.Data.Context;
using Fina.AvaliacaoTecnica.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fina.AvaliacaoTecnica.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        DatabaseContext _databaseContext;

        public RepositoryBase(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public void Add(TEntity entity)
        {
            _databaseContext.Set<TEntity>().Add(entity);
            _databaseContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_databaseContext == null) return;
            _databaseContext.Dispose();      
        }

        public TEntity GetById(int id)
        {
           return  _databaseContext.Set<TEntity>().Find(id);
        }

        public void RemoveAll(IList<int> ids)
        {
            foreach (var id in ids)
            {
                _databaseContext.Set<TEntity>().Remove(this.GetById(id));
            }
            
            _databaseContext.SaveChanges();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _databaseContext.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            _databaseContext.Entry(entity).State = EntityState.Modified;
            _databaseContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            _databaseContext.Set<TEntity>().Remove(entity);
            _databaseContext.SaveChanges();
        }
    }
}
