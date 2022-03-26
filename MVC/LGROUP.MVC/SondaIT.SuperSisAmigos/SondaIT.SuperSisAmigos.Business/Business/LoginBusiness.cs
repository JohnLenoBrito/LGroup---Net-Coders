using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;
using SondaIT.SuperSisAmigos.Repository.Repositories;

namespace SondaIT.SuperSisAmigos.Business.Business
{
    public sealed class LoginBusiness:Base.IReading<LoginModel>,Base.IRecording<LoginModel>
    {
        // readonly = OBJETO SOMENTE PARA LEITURA
        private readonly LoginRepository repository = new LoginRepository();

        public List<LoginModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<LoginModel> GetAll(System.Linq.Expressions.Expression<Func<LoginModel, bool>> Predicate)
        {
            // Predicate EXPRESSÃO LAMBDA
            var query = repository.GetAll(Predicate).ToList();
            if (query.Count() == 0)
            {
                throw new ApplicationException("Usuario ou senha Incorretos");
            }
            else
            {
                return query;
            }
        }

        public LoginModel Find(int ID)
        {
            throw new NotImplementedException();
        }

        public void Add(LoginModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LoginModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LoginModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
