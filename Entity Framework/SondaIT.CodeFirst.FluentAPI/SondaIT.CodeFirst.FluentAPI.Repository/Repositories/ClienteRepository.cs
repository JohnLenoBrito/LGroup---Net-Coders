using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.CodeFirst.FluentAPI.Model;
using SondaIT.CodeFirst.FluentAPI.DataAccess;

namespace SondaIT.CodeFirst.FluentAPI.Repository.Repositories
{
    //Fizemos a herança da interface IRepository e injetamos uma classe modelo, após isso fizemos a implementação da inteface
    //descendo os contratos existentes
    public class ClienteRepository : Base.IRepository<ClienteModel>
    {
        //Implementamos o método GetAll que retorna uma lista do tipo ClienteModel
        public List<ClienteModel> GetAll()
        {
            //Para certificar que a nossa conexão seja fechada fizemos a instancia da classe Conexao dentro do bloco using
            //pois no final do escopo do bloco ele ira disparar automaticamente o Dispose para a classe instanciada
            //No caso a classe de Conexao
            using (var conexao = new Conexao())
            {
                //Aqui criamos uma variavel chamada query para receber o retorno das informações persistidas no banco
                //utilizamos a query link, para fazer a consulta no final convertemos a consulta para uma lista e a retornamos
                //para o metodo
                var query = (from x in conexao.Cliente select x).ToList();

                return query;
            }
        }

        public void Add(ClienteModel novoRegistro)
        {
            using (var conexao = new Conexao())
            {

                //Aqui estamos indo no banco de dados na tabela de clientes e adicionando 1 novo registro "nosso objeto"
                conexao.Cliente.Add(novoRegistro);
                //O EF não é auto commit então utilizamos o metodo SaveChanges para confirma a operação
                conexao.SaveChanges();
            }
        }

        public void Update(ClienteModel atualizarRegistro)
        //Aqui estamos pegando os dados vindo da classe modelo e estamos passando para o banco de daods,
        //utilizamos o EntityState para que o mesmo verifique qual campo sofreu alterações, dessa forma não precisamos atualizar
        //todos os campos do registro, e sim apenas o campo que sofreu alteração
        {
            using (var conexao = new Conexao())
            {
                conexao.Entry<ClienteModel>(atualizarRegistro).State = System.Data.Entity.EntityState.Modified;

                conexao.SaveChanges();
            }
        }

        public void Delete(ClienteModel deletarRegistro)
        {
            using (var conexao = new Conexao())
            {
                //Estamos indo no banco de dados, na tabela de clientes e iremos remover o objeto deletarRegistro
                conexao.Entry<ClienteModel>(deletarRegistro).State = System.Data.Entity.EntityState.Deleted;
                //estamos comitando as informações (salvando)
                conexao.SaveChanges();
            }
        }
    }
}
