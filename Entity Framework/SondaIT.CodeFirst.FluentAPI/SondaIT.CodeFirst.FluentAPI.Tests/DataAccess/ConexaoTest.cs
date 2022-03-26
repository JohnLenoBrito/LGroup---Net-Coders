using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Após baixar a biblioteca de testes (NUNIT), subimos ela pra memória
using NUnit.Framework;

//Subimos pra memoria a DLL de Acesso a DADOS
using SondaIT.CodeFirst.FluentAPI.DataAccess;

//Subimos pra memória a DLL de Armazenamento de DADOS
using SondaIT.CodeFirst.FluentAPI.Model;

namespace SondaIT.CodeFirst.FluentAPI.Tests.DataAccess
{
    //Colocamos o DATA ANNOTATION Do NUNIT pra transformar a classe em uma classe de TESTES (TESTADORA)
    [TestFixture]
    public sealed class ConexaoTest
    {
        //colocamos um DATA ANNOTATION DO NUNIT pra transformar os métodos em comandos de testes do ROBO (CLASSE DE TST)
        [Test]
        public void Testar_Criacao_Do_Banco()
        {
            //Os comandos de teste acionam os comandos originais (comandos verdadeiros)
            var conexao = new Conexao();
            conexao.CriarBanco();
        }

        [Test]
        public void Testar_Exclusao_Do_Banco()
        {
            var conexao = new Conexao();
            conexao.DeletarBanco();
        }
    }
}
