using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.CodeFirst.FluentAPI.Repository.Base
{
    //A ideia da interface é criar as assinaturas do metodos, "padronização", o nome senior disso é contratos
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        
        void Add(TEntity novoRegistro);

        void Update(TEntity atualizarRegistro);

        void Delete(TEntity deletarRegistro);
    }
}
