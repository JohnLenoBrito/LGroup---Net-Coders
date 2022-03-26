using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SondaIT.CodeFirst.FluentAPI.Repository.Repositories;
using SondaIT.CodeFirst.FluentAPI.Model;

namespace SondaIT.CodeFirst.FluentAPI.Tests.Repository
{
    [TestFixture]
    public class ClienteRepositoryTest
    {
        [Test]
        public void ListarRegistos()
        {
            var cliente = new ClienteRepository();

            var totalRegistros = cliente.GetAll().Count();
        }

        [Test]
        public void AdicionarRegistro()
        {
            var cliente = new ClienteRepository();

            var novoCliente = new ClienteModel()
            {
                Nome = "Goku",
                Email = "delk@gfrklg.com",
                Telefone = "325423",
                DataNascimento = new DateTime(1994, 03, 06),
                Salario = 904,
                CodigoSexo = 1,
                CodigoEstadoCivil = 1,
                Endereco = "eçfnepog",
                Cep = "08450",
                Cpf = "41068-27",
                Rg = "37.350-9",
                Pis = "45432"
            };

            cliente.Add(novoCliente);
        }

        [Test]
        public void Atualizar()
        {
            //Instacia da classe de ClienteRepository
            var cliente = new ClienteRepository();
            //Aqui estamos persistindo os dados no banco para recuperar o registro que tenha o codigo 2, como vamos
            //trabalhar com campo a campo do registro convertemos essa query para SingleOrDefault
            var Pesquisar = cliente.GetAll().Where(x => x.Codigo == 2).SingleOrDefault();

            //Aqui estamos setando os campos Email e DataNascimento
            Pesquisar.Email = "zina@ig.com";
            Pesquisar.DataNascimento = new DateTime(2012, 02, 01);

            //Aqui estamos acionando o metodo update do Repository
            cliente.Update(Pesquisar);
        }

        [Test]
        public void DeletarRegistro()
        {
            var cliente = new ClienteRepository();

            var Pesquisar = cliente.GetAll().Where(x => x.Codigo == 2).SingleOrDefault();

            //Passando o registro do cliente a ser deletado
            cliente.Delete(Pesquisar);
        }
    }
}
