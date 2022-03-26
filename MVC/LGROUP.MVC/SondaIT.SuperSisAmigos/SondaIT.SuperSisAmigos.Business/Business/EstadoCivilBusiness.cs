using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Business.Business
{
    public sealed class EstadoCivilBusiness : Base.IReading<EstadoCivilModel>, Base.IRecording<EstadoCivilModel>
    {
        public List<EstadoCivilModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<EstadoCivilModel> GetAll(System.Linq.Expressions.Expression<Func<EstadoCivilModel, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public EstadoCivilModel Find(int ID)
        {
            throw new NotImplementedException();
        }

        public void Add(EstadoCivilModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(EstadoCivilModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EstadoCivilModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
