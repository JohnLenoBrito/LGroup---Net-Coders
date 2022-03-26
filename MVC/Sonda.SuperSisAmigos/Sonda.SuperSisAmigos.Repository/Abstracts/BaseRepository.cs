using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.Repository.Abstracts
{
    public abstract class BaseRepository<TEntity> : Base.IReading<TEntity>, Base.IRecording<TEntity>, IDisposable
    {
        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(int ID)
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int ID)
        {
            throw new NotImplementedException();
        }

        public void Update(System.Linq.Expressions.Expression<Func<TEntity, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
