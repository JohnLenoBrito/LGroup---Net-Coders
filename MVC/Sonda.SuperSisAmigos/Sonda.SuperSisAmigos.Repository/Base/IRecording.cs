using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.Repository.Base
{
    public interface IRecording<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        void Delete(TEntity entity);
        
        void Delete(int ID);

        void Delete(Expression<Func<TEntity, Boolean>> Predicate);

        void Update(TEntity entity);

        void Update(int ID);

        void Update(Expression<Func<TEntity, Boolean>> Predicate);
    }
}
