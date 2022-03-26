using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Business.Business
{
    public sealed class SexoBusiness : Base.IReading<SexoModel>, Base.IRecording<SexoModel>
    {
        public List<SexoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SexoModel> GetAll(System.Linq.Expressions.Expression<Func<SexoModel, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public SexoModel Find(int ID)
        {
            throw new NotImplementedException();
        }

        public void Add(SexoModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SexoModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SexoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
