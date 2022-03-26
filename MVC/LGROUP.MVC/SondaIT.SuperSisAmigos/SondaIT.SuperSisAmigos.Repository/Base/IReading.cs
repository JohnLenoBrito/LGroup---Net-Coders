using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.SuperSisAmigos.Repository.Base
{
    public interface IReading <TEntity> where TEntity:class
    {
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity,Boolean>> Predicate );
        TEntity Find(int ID);

    }
}
