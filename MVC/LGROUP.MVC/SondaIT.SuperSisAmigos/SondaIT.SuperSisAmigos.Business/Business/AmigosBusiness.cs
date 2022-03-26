using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Business.Business
{
    public sealed class AmigosBusiness : Base.IReading<AmigosModel>, Base.IRecording<AmigosModel>
    {
        public List<AmigosModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AmigosModel> GetAll(System.Linq.Expressions.Expression<Func<AmigosModel, bool>> Predicate)
        {
            throw new NotImplementedException();
        }

        public AmigosModel Find(int ID)
        {
            throw new NotImplementedException();
        }

        public void Add(AmigosModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AmigosModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AmigosModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
